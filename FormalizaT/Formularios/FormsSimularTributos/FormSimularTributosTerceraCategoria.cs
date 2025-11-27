using FormalizaT.EstructuraDeDatos;
using FormalizaT.Utilidades;
using System.Globalization;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosTerceraCategoria : Form
    {
        public FormSimularTributosTerceraCategoria()
        {
            InitializeComponent();
            InicializarRegimenes();
        }

        private FormSimularTributos formSimularTributos;

        // Valor referencial de la UIT 2025 (según SUNAT)
        private const decimal UIT = 5350m;

        public Panel TerceraCategoria => panelSimularTributosTerceraCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosTerceraCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void InicializarRegimenes()
        {
            cmbRegimenes.Items.Clear();
            cmbRegimenes.Items.Add("RUS (Categorías 1 y 2)");
            cmbRegimenes.Items.Add("RER (1.5%)");
            cmbRegimenes.Items.Add("MYPE Tributario");
            cmbRegimenes.Items.Add("Régimen General (29.5%)");
        }
        // --- TRAMOS MYPE ---
        private class Tramo
        {
            public decimal Limite { get; set; }
            public decimal Tasa { get; set; }
        }
        private ListaEnlazada<Tramo> CrearTramosMype()
        {
            var lista = new ListaEnlazada<Tramo>();
            lista.Agregar(new Tramo { Limite = 15 * UIT, Tasa = 0.10m });
            lista.Agregar(new Tramo { Limite = decimal.MaxValue, Tasa = 0.295m });
            return lista;
        }
        private decimal CalcularMype(decimal utilidad)
        {
            var tramos = CrearTramosMype();
            var nodo = tramos.Inicio;
            decimal anterior = 0m;
            decimal impuesto = 0m;

            while (nodo != null)
            {
                var tramo = nodo.Valor;
                if (utilidad <= tramo.Limite)
                {
                    impuesto += (utilidad - anterior) * tramo.Tasa;
                    break;
                }
                else
                {
                    impuesto += (tramo.Limite - anterior) * tramo.Tasa;
                    anterior = tramo.Limite;
                }
                nodo = nodo.Siguiente;
            }
            return impuesto;
        }
        private void simularImporte_Click(object sender, EventArgs e)
        {
            string textoIngresos = txtMontoBruto.Text?.Trim() ?? string.Empty;
            string textoGastos = txtMontoNeto.Text?.Trim() ?? string.Empty;

            if (!decimal.TryParse(textoIngresos, out decimal ingresos) ||
                !decimal.TryParse(textoGastos, out decimal gastos))
            {
                lblResultados.Text = "Ingrese valores válidos.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            decimal utilidad = ingresos - gastos;
            if (utilidad < 0)
            {
                lblResultados.Text = "Pérdida: gastos mayores a ingresos.";
                lblImpuesto.Text = "";
                return;
            }

            if (cmbRegimenes.SelectedIndex == -1)
            {
                lblResultados.Text = "Seleccione un régimen.";
                return;
            }

            string regimen = cmbRegimenes.SelectedItem.ToString();
            decimal impuesto = 0m;

            // ----- RUS -----
            if (regimen.Contains("RUS"))
            {
                if (ingresos <= 5000m)
                {
                    impuesto = 20m;  // Categoría 1
                }
                else if (ingresos <= 8000m)
                {
                    impuesto = 50m;  // Categoría 2
                }
                else
                {
                    lblResultados.Text = "El monto supera el límite del RUS.";
                    lblImpuesto.Text = "";
                    return;
                }
            }

            // ----- RER -----
            else if (regimen.Contains("RER"))
            {
                impuesto = ingresos * 0.015m;
            }
            // ----- MYPE -----
            else if (regimen.Contains("MYPE"))
            {
                impuesto = CalcularMype(utilidad);
            }
            // ----- GENERAL -----
            else if (regimen.Contains("General"))
            {
                impuesto = utilidad * 0.295m;
            }

            decimal resultado = utilidad - impuesto;

            lblImpuesto.Text = $"Impuesto: {impuesto.ToString("C2")}";
            lblResultados.Text = $"Utilidad neta después de impuesto: {resultado.ToString("C2")}";
        }

        private void txtMontoBruto_TextChanged(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            lblImpuesto.Text = "";
        }
        private void txtMontoNeto_TextChanged(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            lblImpuesto.Text = "";
        }
        private void cmbRegimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            lblImpuesto.Text = "";
        }
        private void Ayuda_Click(object sender, EventArgs e)
        {
            var texto =
                "Simulación — Tercera Categoría:" + Environment.NewLine +
                "- Regímenes disponibles:" + Environment.NewLine +
                "  • RUS: cuotas fijas por categoría (Cat.1 y Cat.2). Límites de ingresos para aplicar RUS." + Environment.NewLine +
                "  • RER: tasa sobre ingresos (1.5%)." + Environment.NewLine +
                "  • MYPE Tributario: impuesto por tramos sobre la utilidad (10% hasta 15 UIT; 29.5% sobre el exceso)." + Environment.NewLine +
                "  • Régimen General: impuesto sobre la utilidad con tasa aproximada 29.5%." + Environment.NewLine +
                "- Uso del formulario:" + Environment.NewLine +
                "  1) Introduce Ingresos (monto bruto) y Gastos (monto que deduces)." + Environment.NewLine +
                "  2) Selecciona el régimen que corresponde a tu actividad." + Environment.NewLine +
                "  3) Pulsa 'Simular' para ver el valor de 'Impuesto' y la 'Utilidad neta después de impuesto'." + Environment.NewLine +
                "- Notas:" + Environment.NewLine +
                "  • UIT referencial usada: 5350 (2025)." + Environment.NewLine +
                "  • Si la utilidad es negativa, el formulario mostrará 'Pérdida'." + Environment.NewLine +
                "  • Los resultados son orientativos: verifica la normativa vigente y redondeos." + Environment.NewLine +
                "  • Formato: usa números (se admiten decimales y separadores).";

            MensajeEmergente.Mostrar(texto, "Ayuda - Simulación de Tributos Tercera Categoría");
        }
    }
}
