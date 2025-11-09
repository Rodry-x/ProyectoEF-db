using FormalizaT.Utilidades;
using System.Globalization;
using System.Text;
using System.Collections.Generic; // para List<T>

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosSegundaCategoria : Form
    {
        // Estructura de datos para guardar las simulaciones realizadas
        private List<string> historialSegundaCategoria = new List<string>();

        public FormSimularTributosSegundaCategoria()
        {
            InitializeComponent();
        }

        private FormSimularTributos formSimularTributos;

        public Panel SegundaCategoria => panelSimularTributoSegundaCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributoSegundaCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void simularImporte_Click(object sender, EventArgs e)
        {
            var impuestoBuilder = new StringBuilder();
            var resultadoBuilder = new StringBuilder();
            bool anyValue = false;

            // Procesar txtMonto (5%)
            if (!string.IsNullOrWhiteSpace(txtMontoBruto.Text))
            {
                var parsed = CalcularImpuestoYResultado(txtMontoBruto.Text, 0.05m);
                if (parsed == null)
                {
                    lblResultados.Text = "Formato de monto inválido en 'Monto'.";
                    lblImpuesto.Text = string.Empty;
                    return;
                }

                impuestoBuilder.AppendLine($"Bruta: {parsed.Value.impuesto}");
                resultadoBuilder.AppendLine($"Bruta: {parsed.Value.resultado}");
                anyValue = true;

                // Guardar en la estructura de datos
                historialSegundaCategoria.Add($"Monto Bruto: {txtMontoBruto.Text} | Impuesto: {parsed.Value.impuesto} | Resultado: {parsed.Value.resultado}");
            }

            // Procesar txtNeta (6.25%)
            if (!string.IsNullOrWhiteSpace(txtMontoNeto.Text))
            {
                var parsed = CalcularImpuestoYResultado(txtMontoNeto.Text, 0.0625m);
                if (parsed == null)
                {
                    lblResultados.Text = "Formato de monto inválido en 'Neta'.";
                    lblImpuesto.Text = string.Empty;
                    return;
                }

                impuestoBuilder.AppendLine($"Neta: {parsed.Value.impuesto}");
                resultadoBuilder.AppendLine($"Neta: {parsed.Value.resultado}");
                anyValue = true;

                // Guardar también en la lista
                historialSegundaCategoria.Add($"Monto Neto: {txtMontoNeto.Text} | Impuesto: {parsed.Value.impuesto} | Resultado: {parsed.Value.resultado}");
            }

            if (!anyValue)
            {
                lblResultados.Text = "Ingrese un monto.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            // Mostrar resultados finales
            lblImpuesto.Text = impuestoBuilder.ToString().TrimEnd();
            lblResultados.Text = resultadoBuilder.ToString().TrimEnd();
        }

        private (string impuesto, string resultado)? CalcularImpuestoYResultado(string texto, decimal tasaImpuesto)
        {
            string t = texto?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(t))
                return null;

            if (!decimal.TryParse(t, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal monto) &&
                !decimal.TryParse(t, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out monto))
            {
                return null;
            }

            decimal impuesto = monto * tasaImpuesto;
            decimal resultado = monto - impuesto;

            return (impuesto.ToString("C2", CultureInfo.CurrentCulture), resultado.ToString("C2", CultureInfo.CurrentCulture));
        }
    }
}