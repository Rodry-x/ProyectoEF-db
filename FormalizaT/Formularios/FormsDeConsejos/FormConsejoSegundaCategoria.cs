using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsDeConsejos
{
    public partial class FormConsejoSegundaCategoria : Form
    {
        public FormConsejoSegundaCategoria()
        {
            InitializeComponent();
        }

        private FormConsejos formConsejos;

        public Panel PanelConsejoSegundaCategoriaControl => panelConsejoSegundaCategoria;

        private void cambiarAlPanelConsejos(object sender, EventArgs e)
        {
            formConsejos = new FormConsejos();
            PanelController.CambiarPanel(panelConsejoSegundaCategoria, formConsejos.PanelConsejosControl);
        }

        private void linkPaginaRentaSegundaCategoriaExecciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://personas.sunat.gob.pe/vendo-mi-casa/rentas-segunda-categoria");
        }

        private void linkPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://cdn.www.gob.pe/uploads/document/file/4014659/3817927-cronograma_2025.pdf?v=1736202698");
        }
    }
}
