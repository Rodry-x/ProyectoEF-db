
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormSeguridadSocial : Form
    {
        public FormSeguridadSocial()
        {
            InitializeComponent();
        }

        public Panel PanelSeguridadSocialControl => panelQueEsElRuc;
        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }
    }
}
