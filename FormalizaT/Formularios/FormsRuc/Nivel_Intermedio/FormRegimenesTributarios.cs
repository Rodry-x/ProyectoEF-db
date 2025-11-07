using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormRegimenesTributarios : Form
    {
        public FormRegimenesTributarios()
        {
            InitializeComponent();
        }

        public Panel PanelRegimenesTributariosControl => panelQueEsElRuc;
        private FormRegimenesTributarios2 formRegimenesTributarios2;
        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }

        private void cambiarAlPanelTributo2_Click(object sender, EventArgs e)
        {
            formRegimenesTributarios2 = new FormRegimenesTributarios2();
            PanelController.CambiarPanel(panelQueEsElRuc, formRegimenesTributarios2.PanelRegimenesTributarios2Control);
        }
    }
}
