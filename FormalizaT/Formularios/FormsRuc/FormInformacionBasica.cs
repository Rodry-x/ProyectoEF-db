using FormalizaT.Utilidades;
using FormalizaT.Formularios;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormInformacionBasica : Form
    {
        public FormInformacionBasica()
        {
            InitializeComponent();
        }

        private FormConsultaRuc formConsultaRuc;
        private FormQueEsElRuc formQueEsElRuc;
        private FormQuienDebeInscribirseEnElRuc formQuienDebeInscribirseEnElRuc;

        public Panel PanelInformacionBasicaControl => panelInformacionBasica;

        private void cambiarAlPanelConsultarRuc(object sender, EventArgs e)
        {
            formConsultaRuc = new FormConsultaRuc();
            PanelController.CambiarPanel(panelInformacionBasica, formConsultaRuc.PanelConsultaRucControl);
        }

        private void cambiarAlPanelTiposDeRenta(object sender, EventArgs e)
        {

        }

        private void cambiarAlPanelQueEsElRuc(object sender, EventArgs e)
        {
            formQueEsElRuc = new FormQueEsElRuc();
            PanelController.CambiarPanel(panelInformacionBasica, formQueEsElRuc.PanelQueEsElRucControl);
        }

        private void cambiarQuienDebeInscribirseEnElRuc(object sender, EventArgs e)
        {
            formQuienDebeInscribirseEnElRuc = new FormQuienDebeInscribirseEnElRuc();
            PanelController.CambiarPanel(panelInformacionBasica, formQuienDebeInscribirseEnElRuc.PanelQuienDebeInscribirseEnElRucControl);
        }

        private void cambiarAlPanelFuentes(object sender, EventArgs e)
        {

        }
    }
}
