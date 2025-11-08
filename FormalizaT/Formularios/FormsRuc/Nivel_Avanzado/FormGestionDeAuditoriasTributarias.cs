

using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormGestionDeAuditoriasTributarias : Form
    {
        public FormGestionDeAuditoriasTributarias()
        {
            InitializeComponent();
        }
        public Panel PanelAuditoria => panelQueEsElRuc;
        private FormInformacionAvanzada formInformacionAvanzada;

        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }
    }
}
