

using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsDeConsejos
{
    public partial class FormConsejoQuintaCategoria : Form
    {
        public FormConsejoQuintaCategoria()
        {
            InitializeComponent();
        }
        private FormConsejos formConsejos;
        public Panel PanelConsejoQuintaCategoriaControl => panelConsejoQuintaCategoria;

        private void cambiarAlPanelConsejos_Click(object sender, EventArgs e)
        {
            formConsejos = new FormConsejos();
            PanelController.CambiarPanel(panelConsejoQuintaCategoria, formConsejos.PanelConsejosControl);
        }
    }
}
