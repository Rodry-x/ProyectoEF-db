
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormFinanciamientoYCreditos : Form
    {
        public FormFinanciamientoYCreditos()
        {
            InitializeComponent();
        }
        public Panel PanelFinanciamientoYCreditos => panelQueEsElRuc;
        private FormInformacionAvanzada formInformacionAvanzada;

        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }
    }
}
