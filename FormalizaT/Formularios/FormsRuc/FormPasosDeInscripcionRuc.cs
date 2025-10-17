using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormPasosDeInscripcionRuc : Form
    {
        public FormPasosDeInscripcionRuc()
        {
            InitializeComponent();
        }

        private FormQuienDebeInscribirseEnElRuc formQuienDebeInscribirseEnElRuc;

        public Panel PanelInscripcionRucControl => panelInscripcionRuc;

        private void linkVideoPasoAPasoDeInscripcionRUC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.youtube.com/watch?v=t-G6G3MKjao");
        }

        private void cambiarAlPanelTiposDeRenta(object sender, EventArgs e)
        {

        }

        private void cambiarAlPanelQuienDebeInscribirseEnElRuc(object sender, EventArgs e)
        {
            formQuienDebeInscribirseEnElRuc = new FormQuienDebeInscribirseEnElRuc();
            PanelController.CambiarPanel(panelInscripcionRuc, formQuienDebeInscribirseEnElRuc.PanelQuienDebeInscribirseEnElRucControl);
        }

        private void linkParaGenerarClaveSOl_LinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://ww1.sunat.gob.pe/ol-ti-itadminforuc-inscripcion/inscripcion");
        }
    }
}
