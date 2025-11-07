
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormEducaciónFinanciera : Form
    {
        public FormEducaciónFinanciera()
        {
            InitializeComponent();
        }

        public Panel PanelEducacionFinancieraControl => panelQueEsElRuc;

        private FormInformacionIntermedia formInformacionIntermedia;
        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }
    }
}
