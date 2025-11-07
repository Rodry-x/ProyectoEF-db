

using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormEmisiónComprobantesElectrónicos : Form
    {
        public FormEmisiónComprobantesElectrónicos()
        {
            InitializeComponent();
        }

        public Panel PanelEmisionComprobantesElectrónicosControl => panelQueEsElRuc;
        private FormEmisiónComprobantesElectrónicos2 formComprobanteElectronico2;
        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }

        private void cambiarAlPanelComprobante2_Click(object sender, EventArgs e)
        {
            formComprobanteElectronico2 = new FormEmisiónComprobantesElectrónicos2();
            PanelController.CambiarPanel(panelQueEsElRuc, formComprobanteElectronico2.PanelEmisiónComprobantesElectrónicos2Control);
        }
    }
}
