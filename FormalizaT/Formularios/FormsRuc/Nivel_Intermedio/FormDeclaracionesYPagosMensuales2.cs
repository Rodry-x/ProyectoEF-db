using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormDeclaracionesYPagosMensuales2 : Form
    {
        public FormDeclaracionesYPagosMensuales2()
        {
            InitializeComponent();
        }

        public Panel PanelDeclaracionesyPagosMensuales2Control => panelQueEsElRuc;

        private FormDeclaracionesYPagosMensuales formDeclaracion;
        private void cambiarAlPanelDeclaracionesyPagos1_Click(object sender, EventArgs e)
        {
            formDeclaracion = new FormDeclaracionesYPagosMensuales();
            PanelController.CambiarPanel(panelQueEsElRuc, formDeclaracion.PanelDeclaracionesYPagosMensualesControl);
        }
    }
}
