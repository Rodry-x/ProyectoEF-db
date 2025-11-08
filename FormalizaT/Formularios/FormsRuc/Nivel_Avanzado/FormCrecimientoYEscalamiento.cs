
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormCrecimientoYEscalamiento : Form
    {
        public FormCrecimientoYEscalamiento()
        {
            InitializeComponent();
        }
        public Panel PanelCrecimientoYEscalamientoControl => panelQueEsElRuc;
        private FormInformacionAvanzada formInformacionAvanzada;

        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }
    }
}
