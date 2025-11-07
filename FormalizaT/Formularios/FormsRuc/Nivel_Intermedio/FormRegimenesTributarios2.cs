
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormRegimenesTributarios2 : Form
    {
        public FormRegimenesTributarios2()
        {
            InitializeComponent();
        }
        public Panel PanelRegimenesTributarios2Control => panelQueEsElRuc;
        private FormRegimenesTributarios formRegimenesTributarios1;
        private FormRegimenesTributarios3 formRegimenesTributarios3;

        private void cambiarAlPanelTributo1_Click(object sender, EventArgs e)
        {
            formRegimenesTributarios1 = new FormRegimenesTributarios();
            PanelController.CambiarPanel(panelQueEsElRuc, formRegimenesTributarios1.PanelRegimenesTributariosControl);
        }

        private void cambiarAlPanelTributo3_Click(object sender, EventArgs e)
        {
            formRegimenesTributarios3 = new FormRegimenesTributarios3();
            PanelController.CambiarPanel(panelQueEsElRuc, formRegimenesTributarios3.PanelRegimenesTributarios3Control);
        }
    }
}
