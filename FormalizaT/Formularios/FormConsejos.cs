using FormalizaT.Formularios.FormsDeConsejos;
using FormalizaT.Utilidades;


namespace FormalizaT.Formularios
{
    public partial class FormConsejos : Form
    {
        public FormConsejos()
        {
            InitializeComponent();
        }

        private FormConsejoPrimeraCategoria formConsejoPrimeraCategoria;
        private FormConsejoSegundaCategoria formConsejoSegundaCategoria;
        private FormConsejoTerceraCategoria formConsejoTerceraCategoria;
        private FormConsejoCuartaCategoria formConsejoCuartaCategoria;
        private FormConsejoQuintaCategoria formConsejoQuintaCategoria;

        public Panel PanelConsejosControl => panelConsejos;

        private void cambiarAlPanelTipsPrimeraCategoria_Click(object sender, EventArgs e)
        {
            formConsejoPrimeraCategoria = new FormConsejoPrimeraCategoria();
            PanelController.CambiarPanel(panelConsejos, formConsejoPrimeraCategoria.PanelConsejoPrimeraCategoriaControl);
        }

        private void cambiarAlPanelTipsSegundaCategoria_Click(object sender, EventArgs e)
        {
            formConsejoSegundaCategoria = new FormConsejoSegundaCategoria();
            PanelController.CambiarPanel(panelConsejos, formConsejoSegundaCategoria.PanelConsejoSegundaCategoriaControl);
        }

        private void cambiarAlPanelTipsTerceraCategoria_Click(object sender, EventArgs e)
        {
            formConsejoTerceraCategoria = new FormConsejoTerceraCategoria();
            PanelController.CambiarPanel(panelConsejos, formConsejoTerceraCategoria.PanelConsejoTerceraCategoriaControl);
        }

        private void cambiarAlPanelTipsCuartaCategoria_Click(object sender, EventArgs e)
        {
            formConsejoCuartaCategoria = new FormConsejoCuartaCategoria();
            PanelController.CambiarPanel(panelConsejos, formConsejoCuartaCategoria.PanelConsejoCuartaCategoriaControl);
        }

        private void cambiarAlPanelTipsQuintaCategoria_Click(object sender, EventArgs e)
        {
            formConsejoQuintaCategoria = new FormConsejoQuintaCategoria();
            PanelController.CambiarPanel(panelConsejos, formConsejoQuintaCategoria.PanelConsejoQuintaCategoriaControl);
        }
    }
}
