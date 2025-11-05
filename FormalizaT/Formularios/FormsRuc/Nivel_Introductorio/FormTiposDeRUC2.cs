using FormalizaT.Utilidades;
using System;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormTiposDeRUC2 : Form
    {
        public FormTiposDeRUC2()
        {
            InitializeComponent();
        }

        private FormTiposDeRUC formTiposDeRUC;
        public Panel PanelTiposDeRUC2Controller => panelTiposDeRUC2;

        private void cambiandoAlPanelTiposDeRUC_Click(object sender, EventArgs e)
        {
            formTiposDeRUC = new FormTiposDeRUC();
            PanelController.CambiarPanel(panelTiposDeRUC2, formTiposDeRUC.PanelEscogerRentaController);
        }
    }
}
