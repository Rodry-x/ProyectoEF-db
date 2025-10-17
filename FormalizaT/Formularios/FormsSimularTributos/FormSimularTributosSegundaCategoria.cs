
using FormalizaT.Utilidades;
using System.Globalization;
using System.Text;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosSegundaCategoria : Form
    {
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
            }

            if (!anyValue)
            {
                lblResultados.Text = "Ingrese un monto.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            // Mostrar resultados; se usan varias líneas si ambos campos fueron completados.
            lblImpuesto.Text = impuestoBuilder.ToString().TrimEnd();
            lblResultados.Text = resultadoBuilder.ToString().TrimEnd();
        }

        private (string impuesto, string resultado)? CalcularImpuestoYResultado(string texto, decimal tasaImpuesto)
        {
            string t = texto?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(t))
                return null;

            if (!decimal.TryParse(t, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal monto) &&
                !decimal.TryParse(t, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out monto))
            {
                return null;
            }

            decimal impuesto = monto * tasaImpuesto;
            decimal resultado = monto - impuesto;

            return (impuesto.ToString("C2", CultureInfo.CurrentCulture), resultado.ToString("C2", CultureInfo.CurrentCulture));
        }
    }
}
