
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormDigitalizacionDelNegocio : Form
    {
        public FormDigitalizacionDelNegocio()
        {
            InitializeComponent();
        }
        public Panel PanelDigitalizacion => panelQueEsElRuc;
        private FormInformacionAvanzada formInformacionAvanzada;

        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }
    }
}
