
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormRegimenesTributarios3 : Form
    {
        public FormRegimenesTributarios3()
        {
            InitializeComponent();
        }
        public Panel PanelRegimenesTributarios3Control => panelQueEsElRuc;
        private FormRegimenesTributarios2 formRegimenesTributarios2;

        private void cambiarAlPanelTributo2_Click(object sender, EventArgs e)
        {
            formRegimenesTributarios2 = new FormRegimenesTributarios2();
            PanelController.CambiarPanel(panelQueEsElRuc, formRegimenesTributarios2.PanelRegimenesTributarios2Control);
        }
    }
}
