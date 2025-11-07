using FormalizaT.Utilidades;

namespace FormalizaT.Formularios
{
    public partial class FormPasosParaFormalizar : Form
    {
        public FormPasosParaFormalizar()
        {
            InitializeComponent();
        }

        private void FormPasosParaFormalizar_Load(object sender, EventArgs e)
        {

        }

        public Panel PanelPasosParaFormalizarControl => panelQueEsElRuc;
        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }
    }
}
