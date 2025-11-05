using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormQueEsElRuc : Form
    {
        public FormQueEsElRuc()
        {
            InitializeComponent();
        }

        private FormInformacionBasica formInformacionBasica;
        private FormParaQueNosSirve formParaQueNosSirve;

        public Panel PanelQueEsElRucControl => panelQueEsElRuc;

        private void cambiarAlPanelInformacionBasica(object sender, EventArgs e)
        {
            formInformacionBasica = new FormInformacionBasica();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionBasica.PanelInformacionBasicaControl);
        }

        private void cambiarAlPanelParaQueNosSirve(object sender, EventArgs e)
        {
            formParaQueNosSirve = new FormParaQueNosSirve();
            PanelController.CambiarPanel(panelQueEsElRuc, formParaQueNosSirve.PanelParaQueNosSirveControl);
        }
    }
}
