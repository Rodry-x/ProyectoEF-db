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

        // Diccionario para almacenar tasas base de regímenes
        private readonly Dictionary<string, decimal> regimenes = new Dictionary<string, decimal>();

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
            regimenes.Add("RUS (Simplificado)", 0.01m);   // Aprox. 1%
            regimenes.Add("RER (Especial)", 0.015m);      // Aprox. 1.5%
            regimenes.Add("MYPE Tributario", 0.10m);      // 10% hasta 15 UIT
            regimenes.Add("Régimen General", 0.295m);     // 29.5%

            cmbRegimenes.Items.Clear();
            foreach (var key in regimenes.Keys)
                cmbRegimenes.Items.Add(key);
        }

        private void simularImporte_Click(object sender, EventArgs e)
        {
            if (cmbRegimenes.SelectedItem == null)
            {
                lblResultados.Text = "Seleccione un régimen tributario.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            string regimenSeleccionado = cmbRegimenes.SelectedItem.ToString();

            // Validar ingresos y gastos
            if (!decimal.TryParse(txtMontoBruto.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal ingresos) ||
                !decimal.TryParse(txtMontoNeto.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal gastos))
            {
                lblResultados.Text = "Ingrese valores válidos para ingresos y gastos.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            // Calcular utilidad
            decimal utilidad = ingresos - gastos;
            if (utilidad < 0)
            {
                lblResultados.Text = "Pérdida: los gastos superan los ingresos.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            decimal impuesto = 0m;

            // Calcular según el régimen
            switch (regimenSeleccionado)
            {
                case "MYPE Tributario":
                    decimal limite = 15 * UIT;
                    if (utilidad <= limite)
                        impuesto = utilidad * 0.10m;
                    else
                        impuesto = (limite * 0.10m) + ((utilidad - limite) * 0.295m);
                    break;

                case "Régimen General":
                    impuesto = utilidad * 0.295m;
                    break;

                case "RER (Especial)":
                    impuesto = utilidad * 0.015m;
                    break;

                case "RUS (Simplificado)":
                    impuesto = utilidad * 0.01m;
                    break;
            }

            decimal resultado = utilidad - impuesto;

            lblImpuesto.Text = $"Impuesto ({regimenSeleccionado}): {impuesto.ToString("C2", CultureInfo.CurrentCulture)}";
            lblResultados.Text = $"Utilidad neta después de impuesto: {resultado.ToString("C2", CultureInfo.CurrentCulture)}";
        }

        private void txtMontoBruto_TextChanged(object sender, EventArgs e)
        {
            lblResultados.Text = string.Empty;
            lblImpuesto.Text = string.Empty;
        }

        private void txtMontoNeto_TextChanged(object sender, EventArgs e)
        {
            lblResultados.Text = string.Empty;
            lblImpuesto.Text = string.Empty;
        }

        private void cmbRegimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultados.Text = string.Empty;
            lblImpuesto.Text = string.Empty;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
