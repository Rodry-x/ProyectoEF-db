using FormalizaT.Formularios.FormsRuc.Nivel_Introductorio;
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormTiposDeRUC : Form
    {
        public FormTiposDeRUC()
        {
            InitializeComponent();
        }

        private FormInformacionBasica formInformacionBasica;
        private FormTiposDeRUC2 formTiposDeRUC2;
        public Panel PanelEscogerRentaController => panelEscogerRenta;

        private void cambiarAlPanelInformacionBasica_Click(object sender, EventArgs e)
        {
            formInformacionBasica = new FormInformacionBasica();
            PanelController.CambiarPanel(panelEscogerRenta, formInformacionBasica.PanelInformacionBasicaControl);
        }
        private void cambiarAlPanelTiposDeRUC2_Click(object sender, EventArgs e)
        {
            formTiposDeRUC2 = new FormTiposDeRUC2();
            PanelController.CambiarPanel(panelEscogerRenta, formTiposDeRUC2.PanelTiposDeRUC2Controller);
        }
    }
}
