using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormClaveSOLySUNATVirtual : Form
    {
        public FormClaveSOLySUNATVirtual()
        {
            InitializeComponent();
        }

        public Panel PanelClaveSOLySUNATVirtualControl => panelQueEsElRuc;

        private FormInformacionIntermedia formInformacionIntermedia;
        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }
    }
}
