using FormalizaT.Utilidades;
using System.Globalization;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosPrimeraCategoria : Form
    {
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
                lblImpuesto.Text = string.Empty; // limpiar etiqueta de impuesto
                lblAdicional.Text = string.Empty; // limpiar adicional
                return;
            }

            // Intentar parsear usando la cultura actual; si falla, intentar InvariantCulture
            if (!decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal monto) &&
                !decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out monto))
            {
                lblResultado.Text = "Formato de monto inválido.";
                lblImpuesto.Text = string.Empty; // limpiar etiqueta de impuesto
                lblAdicional.Text = string.Empty; // limpiar adicional
                return;
            }

            decimal descuento = monto * 0.05m;
            decimal resultado = monto - descuento;

            // Mostrar importe del descuento en lblImpuesto y resultado formateados como moneda en la cultura actual
            lblImpuesto.Text = descuento.ToString("C2", CultureInfo.CurrentCulture);
            lblResultado.Text = resultado.ToString("C2", CultureInfo.CurrentCulture);

            // Nueva lógica: la decisión se basa en lblImpuesto * 12 (impuesto anual)
            decimal impuestoAnual = descuento * 12m;
            const decimal umbralAnual = 600m; // umbral anual mínimo según indicación

            if (impuestoAnual > umbralAnual)
            {
                lblAdicional.Text = "No hay obligacion de presentar declaracion jurada anual";
            }
            else
            {
                decimal diferenciaAnual = umbralAnual - impuestoAnual;
                decimal diferenciaMensual = diferenciaAnual / 12m;
                lblAdicional.Text = "Debe presentar su declaracion jurada anual y pagar la diferencia resultante. " +
                                     $"Diferencia: {diferenciaMensual.ToString("C2", CultureInfo.CurrentCulture)} mensuales " +
                                     $"({diferenciaAnual.ToString("C2", CultureInfo.CurrentCulture)} anuales).";
            }
        }
    }
}
