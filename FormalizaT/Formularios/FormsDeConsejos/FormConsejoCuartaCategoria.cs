
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsDeConsejos
{
    public partial class FormConsejoCuartaCategoria : Form
    {
        public FormConsejoCuartaCategoria()
        {
            InitializeComponent();
        }
        private FormConsejos formConsejos;
        public Panel PanelConsejoCuartaCategoriaControl => panelConsejoCuartaCategoria;

        private void cambiarAlPanelConsejos_Click(object sender, EventArgs e)
        {
            formConsejos = new FormConsejos();
            PanelController.CambiarPanel(panelConsejoCuartaCategoria, formConsejos.PanelConsejosControl);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.google.com/url?sa=i&source=web&rct=j&url=https://www.sunat.gob.pe/&ved=2ahUKEwiWnN_Jn9qQAxVFErkGHeFoF9gQy_kOegQIBhAB&opi=89978449&cd&psig=AOvVaw0a_UJWqziVeFR8gd5w7Gvk&ust=1762405857046000");
        }
    }
}
