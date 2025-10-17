using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormConsultaRuc : Form
    {
        public FormConsultaRuc()
        {
            InitializeComponent();
        }

        private FormInformacionBasica formInformacionBasica;

        public Panel PanelConsultaRucControl => panelConsultaRuc;

        private void consultarRuc(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/FrameCriterioBusquedaWeb.jsp");
        }

        private void cambiarAlPanelInformacionBasica(object sender, EventArgs e)
        {
            formInformacionBasica = new FormInformacionBasica();
            PanelController.CambiarPanel(panelConsultaRuc, formInformacionBasica.PanelInformacionBasicaControl);
        }
    }
}
