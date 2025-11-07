
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormFuentes_int : Form
    {
        public FormFuentes_int()
        {
            InitializeComponent();
        }
        
        public Panel PanelFuentesIntControl => panelFormFuentes_Int;

        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelFormFuentes_Int, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }
    }
}
