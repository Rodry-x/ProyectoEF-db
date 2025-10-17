using FormalizaT.Utilidades;

namespace FormalizaT.Formularios
{
    public partial class FormConsejoPrimeraCategoria : Form
    {
        public FormConsejoPrimeraCategoria()
        {
            InitializeComponent();
        }

        private FormConsejos formConsejos;

        public Panel PanelConsejoPrimeraCategoriaControl => panelConsejoPrimeraCategoria;

        private void linkPaginaDelGobiernoDevolucionDeImpuesto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/23767-devolucion-de-impuestos-para-rentas-de-capital-primera-y-segunda-categoria");
        }

        private void cambiarAlPanelConsejos(object sender, EventArgs e)
        {
            formConsejos = new FormConsejos();
            PanelController.CambiarPanel(panelConsejoPrimeraCategoria, formConsejos.PanelConsejosControl);
        }
    }
}
