

using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosTerceraCategoria : Form
    {
        public FormSimularTributosTerceraCategoria()
        {
            InitializeComponent();
        }
        private FormSimularTributos formSimularTributos;

        public Panel TerceraCategoria => panelSimularTributosTerceraCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosTerceraCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void simularImporte_Click(object sender, EventArgs e)
        {

        }
    }
}
