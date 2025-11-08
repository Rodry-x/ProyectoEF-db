
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormGestionContableYFinanciera : Form
    {
        public FormGestionContableYFinanciera()
        {
            InitializeComponent();
        }
        public Panel PanelGestionContable => panelQueEsElRuc;
        private FormInformacionAvanzada formInformacionAvanzada;

        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }
    }
}
