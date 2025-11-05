using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormParaQueNosSirve : Form
    {
        public FormParaQueNosSirve()
        {
            InitializeComponent();
        }

        private FormQueEsElRuc formQueEsElRuc;

        public Panel PanelParaQueNosSirveControl => panelParaQueNosSirve;

        private void cambiarAlPanelQueEsElRuc(object sender, EventArgs e)
        {
            formQueEsElRuc = new FormQueEsElRuc();
            PanelController.CambiarPanel(panelParaQueNosSirve, formQueEsElRuc.PanelQueEsElRucControl);
        }
    }
}
