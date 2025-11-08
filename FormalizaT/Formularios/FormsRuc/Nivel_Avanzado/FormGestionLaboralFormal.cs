using System;
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormGestionLaboralFormal : Form
    {
        public FormGestionLaboralFormal()
        {
            InitializeComponent();
        }
        public Panel PanelGestionLaboralFormal => panelQueEsElRuc;
        private FormInformacionAvanzada formInformacionAvanzada;
        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelQueEsElRuc, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }
    }
}
