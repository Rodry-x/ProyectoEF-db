

using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsDeConsejos
{
    public partial class FormConsejoTerceraCategoria : Form
    {
        public FormConsejoTerceraCategoria()
        {
            InitializeComponent();
        }
        private FormConsejos formConsejos;
        public Panel PanelConsejoTerceraCategoriaControl => panelConsejoTerceraCategoria;

        private void cambiarAlPanelConsejos_Click(object sender, EventArgs e)
        {
            formConsejos = new FormConsejos();
            PanelController.CambiarPanel(panelConsejoTerceraCategoria, formConsejos.PanelConsejosControl);
        }
    }
}
