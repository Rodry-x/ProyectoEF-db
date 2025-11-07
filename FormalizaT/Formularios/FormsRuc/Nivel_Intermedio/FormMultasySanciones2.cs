
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormMultasySanciones2 : Form
    {
        public FormMultasySanciones2()
        {
            InitializeComponent();
        }
        public Panel PanelMultasySanciones2Control => panelQueEsElRuc;
        private FormMultasySanciones formSancion1;
        private void cambiarAlPanelSancion1_Click(object sender, EventArgs e)
        {
            formSancion1 = new FormMultasySanciones();
            PanelController.CambiarPanel(panelQueEsElRuc, formSancion1.PanelMultasySancionesControl);
        }
    }
}
