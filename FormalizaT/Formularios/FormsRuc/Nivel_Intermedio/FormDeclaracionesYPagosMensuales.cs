using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormDeclaracionesYPagosMensuales : Form
    {
        public FormDeclaracionesYPagosMensuales()
        {
            InitializeComponent();
        }

        public Panel PanelDeclaracionesYPagosMensualesControl => panelQueEsElRuc;

        private FormInformacionIntermedia formInformacionIntermedia;
        private FormDeclaracionesYPagosMensuales2 formDeclaracion2;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }

        private void cambiarAlPanelDeclaracion2_Click(object sender, EventArgs e)
        {
            formDeclaracion2 = new FormDeclaracionesYPagosMensuales2();
            PanelController.CambiarPanel(panelQueEsElRuc, formDeclaracion2.PanelDeclaracionesyPagosMensuales2Control);
        }
    }
}
