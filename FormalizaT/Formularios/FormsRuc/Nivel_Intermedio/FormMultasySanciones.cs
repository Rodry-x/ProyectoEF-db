using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormMultasySanciones : Form
    {
        public FormMultasySanciones()
        {
            InitializeComponent();
        }

        public Panel PanelMultasySancionesControl => panelQueEsElRuc;
        private FormMultasySanciones2 formMultasySanciones2;
        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }

        private void cambiarAlPanelSancion2_Click(object sender, EventArgs e)
        {
            formMultasySanciones2 = new FormMultasySanciones2();
            PanelController.CambiarPanel(panelQueEsElRuc, formMultasySanciones2.PanelMultasySanciones2Control);
        }
    }
}
