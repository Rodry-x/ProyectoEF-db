

using FormalizaT.Utilidades;
using System.Globalization;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosCuartaCategoria : Form
    {
        public FormSimularTributosCuartaCategoria()
        {
            InitializeComponent();
        }
        private FormSimularTributos formSimularTributos;
        public Panel CuartaCategoria => panelSimularTributosCuartaCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosCuartaCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void simularImporte(object sender, EventArgs e)
        {
            string texto = txtMonto.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(texto))
            {
                lblResultado.Text = "Ingrese un monto.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            // Intentar parsear usando la cultura actual; si falla, intentar InvariantCulture
            if (!decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal monto) &&
                !decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out monto))
            {
                lblResultado.Text = "Formato de monto inválido.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            if (monto <= 0)
            {
                lblResultado.Text = "El monto debe ser mayor que cero.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            // Configuración de tramos
            decimal UIT = 5350m;
            decimal[] limitesUIT = { 5m, 20m, 35m, 45m }; // en UIT
            decimal[] tasas = { 0.08m, 0.14m, 0.17m, 0.20m, 0.30m }; // tramos: 0-5, 5-20, 20-35, 35-45, >45

            // Convertir límites a moneda
            decimal[] limites = limitesUIT.Select(u => u * UIT).ToArray();

            // 1) Aplicar deducción: primero descontar 20% del bruto
            decimal bruto = monto;
            decimal despues20 = bruto * 0.80m; // queda el 80%

            // 2) Restar 7 UIT (en moneda) a lo anterior
            decimal deduccion7UIT = 7m * UIT;
            decimal baseImponible = despues20 - deduccion7UIT;

            // Si la base imponible es negativa, no hay base gravable
            if (baseImponible <= 0m)
            {
                decimal impuestoTotalCero = 0m;
                decimal tasaEfectivaCero = 0m;
                decimal netoCero = bruto - impuestoTotalCero;

                lblImpuesto.Text = $"{impuestoTotalCero.ToString("C2", CultureInfo.CurrentCulture)} (tasa efectiva: {tasaEfectivaCero.ToString("P2", CultureInfo.CurrentCulture)})";
                lblResultado.Text = $"{netoCero.ToString("C2", CultureInfo.CurrentCulture)} (base imponible: {baseImponible.ToString("C2", CultureInfo.CurrentCulture)}, tasa marginal: N/A)";
                return;
            }

            // 3) Aplicar tasas por tramo sobre la base imponible resultante
            decimal impuestoTotal = 0m;
            decimal anterior = 0m; // marcador en moneda de la frontera anterior ya gravada
            int tasaIndex = tasas.Length - 1; // por defecto, el último tramo si se pasa por encima

            for (int i = 0; i < limites.Length; i++)
            {
                decimal limite = limites[i];

                if (baseImponible <= limite)
                {
                    decimal sujeto = Math.Max(0m, baseImponible - anterior);
                    impuestoTotal += sujeto * tasas[i];
                    tasaIndex = i;
                    anterior = baseImponible;
                    break;
                }
                else
                {
                    decimal sujeto = Math.Max(0m, limite - anterior);
                    impuestoTotal += sujeto * tasas[i];
                    anterior = limite;
                }
            }

            // Si baseImponible excede el último límite (>45 UIT)
            if (baseImponible > anterior)
            {
                decimal restante = baseImponible - anterior;
                impuestoTotal += restante * tasas[tasas.Length - 1];
                tasaIndex = tasas.Length - 1;
            }

            decimal tasaAplicable = tasas[tasaIndex];

            // Tasa efectiva respecto al bruto (evitar división por cero)
            decimal tasaEfectiva = bruto != 0m ? impuestoTotal / bruto : 0m;
            decimal neto = bruto - impuestoTotal;

            // Mostrar resultados: impuesto total + tasa efectiva, y neto + detalles de la base y tasa marginal
            lblImpuesto.Text = $"{impuestoTotal.ToString("C2", CultureInfo.CurrentCulture)} (tasa efectiva: {tasaEfectiva.ToString("P2", CultureInfo.CurrentCulture)})";
            lblResultado.Text = $"{neto.ToString("C2", CultureInfo.CurrentCulture)} (base imponible: {baseImponible.ToString("C2", CultureInfo.CurrentCulture)}, tasa marginal: {tasaAplicable.ToString("P0", CultureInfo.CurrentCulture)})";
        }
    }
}
