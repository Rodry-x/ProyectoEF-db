using FormalizaT.EstructuraDeDatos;
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

        // --- Estructura de datos para tramos de IR ---
        private class TramoIR
        {
            public decimal Limite { get; set; }   // Límite superior del tramo en soles
            public decimal Tasa { get; set; }     // Tasa correspondiente
        }

        private void simularImporte(object sender, EventArgs e)
        {
            string texto = txtMonto.Text?.Trim() ?? "";

            // Validaciones
            if (string.IsNullOrEmpty(texto))
            {
                lblResultado.Text = "Ingrese un monto.";
                lblImpuesto.Text = "";
                return;
            }

            if (!decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                CultureInfo.CurrentCulture, out decimal monto) &&
                !decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                CultureInfo.InvariantCulture, out monto))
            {
                lblResultado.Text = "Formato de monto inválido.";
                lblImpuesto.Text = "";
                return;
            }

            if (monto <= 0)
            {
                lblResultado.Text = "El monto debe ser mayor que cero.";
                lblImpuesto.Text = "";
                return;
            }

            // Parámetros SUNAT 2025
            decimal UIT = 5350m;

            //    LISTA ENLAZADA PROPIA

            ListaEnlazada<TramoIR> tramos = new ListaEnlazada<TramoIR>();

            tramos.Agregar(new TramoIR { Limite = 5m * UIT, Tasa = 0.08m });
            tramos.Agregar(new TramoIR { Limite = 20m * UIT, Tasa = 0.14m });
            tramos.Agregar(new TramoIR { Limite = 35m * UIT, Tasa = 0.17m });
            tramos.Agregar(new TramoIR { Limite = 45m * UIT, Tasa = 0.20m });
            tramos.Agregar(new TramoIR { Limite = decimal.MaxValue, Tasa = 0.30m });

            //  CÁLCULO TRIBUTARIO 4ta CATEGORÍA  //

            decimal bruto = monto;
            decimal despues20 = bruto * 0.80m;
            decimal deduccion7UIT = 7m * UIT;

            decimal baseImponible = despues20 - deduccion7UIT;

            if (baseImponible <= 0)
            {
                lblImpuesto.Text = "S/ 0.00 (tasa efectiva: 0%)";
                lblResultado.Text = $"{bruto.ToString("C2")} (base imponible: S/ 0.00, tasa marginal: N/A)";
                return;
            }

            decimal impuestoTotal = 0m;
            decimal anterior = 0m;
            decimal tasaMarginal = 0m;

            // Recorremos la lista enlazada manualmente
            foreach (TramoIR tramo in tramos.ObtenerElementos())
            {
                if (baseImponible <= tramo.Limite)
                {
                    decimal sujeto = baseImponible - anterior;
                    impuestoTotal += sujeto * tramo.Tasa;
                    tasaMarginal = tramo.Tasa;
                    break;
                }
                else
                {
                    decimal sujeto = tramo.Limite - anterior;
                    impuestoTotal += sujeto * tramo.Tasa;
                    anterior = tramo.Limite;
                }
            }

            decimal tasaEfectiva = impuestoTotal / bruto;
            decimal neto = bruto - impuestoTotal;

            //  SALIDA  //

            lblImpuesto.Text =
                $"{impuestoTotal.ToString("C2")} (tasa efectiva: {tasaEfectiva.ToString("P2")})";

            lblResultado.Text =
                $"{neto.ToString("C2")} (base imponible: {baseImponible.ToString("C2")}, tasa marginal: {tasaMarginal.ToString("P0")})";
        }
    }
}