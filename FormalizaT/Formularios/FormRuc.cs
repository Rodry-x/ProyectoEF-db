using FormalizaT.Utilidades;
using FormalizaT.Formularios.FormsRuc;

namespace FormalizaT.Formularios
{
    public partial class FormRuc : Form
    {

        public FormRuc()
        {
            InitializeComponent();
        }
        private FormInformacionIntermedia formInformacionIntermedia;
        private FormInformacionBasica formInformacionBasica;

        public Panel PanelRucControl => panelRuc;

        private void cambiarAlPanelInformacionBasica(object sender, EventArgs e)
        {
            formInformacionBasica = new FormInformacionBasica();
            PanelController.CambiarPanel(panelRuc, formInformacionBasica.PanelInformacionBasicaControl);
        }

        private void cambiarAlPanelInformacionIntermedia(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }

        private void cambiarAlPanelInformacionAvanzada(object sender, EventArgs e)
        {
            
        }
    }
}
