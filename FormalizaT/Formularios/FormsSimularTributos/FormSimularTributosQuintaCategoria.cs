
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosQuintaCategoria : Form
    {
        public FormSimularTributosQuintaCategoria()
        {
            InitializeComponent();
        }

        private FormSimularTributos formSimularTributos;

        public Panel QuintaCategoria => panelSimularTributosQuintaCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosQuintaCategoria, formSimularTributos.PanelSimularTributosControl);
        }
    }
}
