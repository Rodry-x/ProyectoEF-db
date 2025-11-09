using FormalizaT.Utilidades;
using System.Globalization;
using System.Collections.Generic; // para List<T>

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosPrimeraCategoria : Form
    {
        // Lista para almacenar los resultados o montos simulados
        private List<string> historialSimulaciones = new List<string>();

        public FormSimularTributosPrimeraCategoria()
        {
            InitializeComponent();
        }

        private FormSimularTributos formSimularTributos;

        public Panel PrimeraCategoria => panelSimularTributosPrimeraCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosPrimeraCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void simularImporte_Click(object sender, EventArgs e)
        {
            string texto = txtMonto.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(texto))
            {
                lblResultado.Text = "Ingrese un monto.";
                lblImpuesto.Text = string.Empty;
                lblAdicional.Text = string.Empty;
                return;
            }

            if (!decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal monto) &&
                !decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out monto))
            {
                lblResultado.Text = "Formato de monto inválido.";
                lblImpuesto.Text = string.Empty;
                lblAdicional.Text = string.Empty;
                return;
            }

            decimal descuento = monto * 0.05m;
            decimal resultado = monto - descuento;

            lblImpuesto.Text = descuento.ToString("C2", CultureInfo.CurrentCulture);
            lblResultado.Text = resultado.ToString("C2", CultureInfo.CurrentCulture);

            decimal impuestoAnual = descuento * 12m;
            const decimal umbralAnual = 600m;

            string mensaje;
            if (impuestoAnual > umbralAnual)
            {
                mensaje = "No hay obligación de presentar declaración jurada anual";
            }
            else
            {
                decimal diferenciaAnual = umbralAnual - impuestoAnual;
                decimal diferenciaMensual = diferenciaAnual / 12m;
                mensaje = "Debe presentar su declaración jurada anual y pagar la diferencia resultante. " +
                          $"Diferencia: {diferenciaMensual.ToString("C2", CultureInfo.CurrentCulture)} mensuales " +
                          $"({diferenciaAnual.ToString("C2", CultureInfo.CurrentCulture)} anuales).";
            }

            lblAdicional.Text = mensaje;

            // Guardamos un resumen de la simulación en la lista (estructura de datos)
            historialSimulaciones.Add(
                $"Monto: {monto.ToString("C2")} | Descuento: {descuento.ToString("C2")} | Resultado: {resultado.ToString("C2")} | {mensaje}"
            );
        }
    }
}