using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormQuienDebeInscribirseEnElRuc : Form
    {
        public FormQuienDebeInscribirseEnElRuc()
        {
            InitializeComponent();
        }

        private FormInformacionBasica formInformacionBasica;
        private FormPasosDeInscripcionRuc formPasosDeInscripcionRuc;

        public Panel PanelQuienDebeInscribirseEnElRucControl => panelQuienDebeInscribirseEnElRuc;

        private void cambiarAlPanelInformacionBasica(object sender, EventArgs e)
        {
            formInformacionBasica = new FormInformacionBasica();
            PanelController.CambiarPanel(panelQuienDebeInscribirseEnElRuc, formInformacionBasica.PanelInformacionBasicaControl);
        }

        private void cambiarAlPanelInscripcionRuc(object sender, EventArgs e)
        {
            formPasosDeInscripcionRuc = new FormPasosDeInscripcionRuc();
            PanelController.CambiarPanel(panelQuienDebeInscribirseEnElRuc, formPasosDeInscripcionRuc.PanelInscripcionRucControl);
        }
    }
}
