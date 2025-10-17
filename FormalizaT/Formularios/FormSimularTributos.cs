using FormalizaT.Utilidades;
using FormalizaT.Formularios.FormsSimularTributos;

namespace FormalizaT.Formularios
{
    public partial class FormSimularTributos : Form
    {
        public FormSimularTributos()
        {
            InitializeComponent();
        }

        private FormSimularTributosPrimeraCategoria formSimularTributosPrimeraCategoria;
        private FormSimularTributosSegundaCategoria formSimularTributosSegundaCategoria;
        private FormSimularTributosTerceraCategoria formSimularTributosTerceraCategoria;
        private FormSimularTributosCuartaCategoria formSimularTributosCuartaCategoria;
        private FormSimularTributosQuintaCategoria formSimularTributosQuintaCategoria;

        public Panel PanelSimularTributosControl => panelSimularTributos;

        private void cambiarAlPanelSTPrimeraCategoria(object sender, EventArgs e)
        {
            formSimularTributosPrimeraCategoria = new FormSimularTributosPrimeraCategoria();
            PanelController.CambiarPanel(panelSimularTributos, formSimularTributosPrimeraCategoria.PrimeraCategoria);
        }

        private void CambiarAlPanelSTSegundaCategoria(object sender, EventArgs e)
        {
            formSimularTributosSegundaCategoria = new FormSimularTributosSegundaCategoria();
            PanelController.CambiarPanel(panelSimularTributos, formSimularTributosSegundaCategoria.SegundaCategoria);
        }

        private void cambiarAlPanelSTTerceraCategoria(object sender, EventArgs e)
        {
            formSimularTributosTerceraCategoria = new FormSimularTributosTerceraCategoria();
            PanelController.CambiarPanel(panelSimularTributos, formSimularTributosTerceraCategoria.TerceraCategoria);
        }

        private void cambiarAlPanelSTCuartaCategoria(object sender, EventArgs e)
        {
            formSimularTributosCuartaCategoria = new FormSimularTributosCuartaCategoria();
            PanelController.CambiarPanel(panelSimularTributos, formSimularTributosCuartaCategoria.CuartaCategoria);
        }

        private void cambiarAlPanelSTQuintaCategoria(object sender, EventArgs e)
        {
            formSimularTributosQuintaCategoria = new FormSimularTributosQuintaCategoria();
            PanelController.CambiarPanel(panelSimularTributos, formSimularTributosQuintaCategoria.QuintaCategoria);
        }
    }
}
