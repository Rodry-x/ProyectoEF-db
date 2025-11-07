
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormEmisiónComprobantesElectrónicos2 : Form
    {
        public FormEmisiónComprobantesElectrónicos2()
        {
            InitializeComponent();
        }
        public Panel PanelEmisiónComprobantesElectrónicos2Control => panelQueEsElRuc;

        private FormEmisiónComprobantesElectrónicos formComprobanteElectronico1;
        private void cambiarAlPanelComprobante1_Click(object sender, EventArgs e)
        {
            formComprobanteElectronico1 = new FormEmisiónComprobantesElectrónicos();
            PanelController.CambiarPanel(panelQueEsElRuc, formComprobanteElectronico1.PanelEmisionComprobantesElectrónicosControl);
        }
    }
}
