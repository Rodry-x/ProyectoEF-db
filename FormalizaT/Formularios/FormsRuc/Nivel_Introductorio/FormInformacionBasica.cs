using FormalizaT.Utilidades;
using FormalizaT.Formularios;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormInformacionBasica : Form
    {
        public FormInformacionBasica()
        {
            InitializeComponent();
        }

        private FormConsultaRuc formConsultaRuc;
        private FormQueEsElRuc formQueEsElRuc;
        private FormFuentes formFuentes;
        private FormTiposDeRUC formTiposDeRenta;
        private FormQuienDebeInscribirseEnElRuc formQuienDebeInscribirseEnElRuc;

        public Panel PanelInformacionBasicaControl => panelInformacionBasica;

        private void cambiarAlPanelConsultarRuc(object sender, EventArgs e)
        {
            formConsultaRuc = new FormConsultaRuc();
            PanelController.CambiarPanel(panelInformacionBasica, formConsultaRuc.PanelConsultaRucControl);
        }

        private void cambiarAlPanelTiposDeRenta(object sender, EventArgs e)
        {
            formTiposDeRenta = new FormTiposDeRUC();
            PanelController.CambiarPanel(panelInformacionBasica, formTiposDeRenta.PanelEscogerRentaController);
        }

        private void cambiarAlPanelQueEsElRuc(object sender, EventArgs e)
        {
            formQueEsElRuc = new FormQueEsElRuc();
            PanelController.CambiarPanel(panelInformacionBasica, formQueEsElRuc.PanelQueEsElRucControl);
        }

        private void cambiarQuienDebeInscribirseEnElRuc(object sender, EventArgs e)
        {
            formQuienDebeInscribirseEnElRuc = new FormQuienDebeInscribirseEnElRuc();
            PanelController.CambiarPanel(panelInformacionBasica, formQuienDebeInscribirseEnElRuc.PanelQuienDebeInscribirseEnElRucControl);
        }

        private void cambiarAlPanelFuentes(object sender, EventArgs e)
        {
            formFuentes = new FormFuentes();
            PanelController.CambiarPanel(panelInformacionBasica, formFuentes.PanelFuentesControl);
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            var texto =
                "Consultar Ruc: Nos sirve para ver quienes tienen ruc activo y todo su historial." + Environment.NewLine +
                "Tipos de RUC: para saber las diferencias entre Persona Jurídica y Natural." + Environment.NewLine +
                "¿Que es un RUC?: las características del RUC." + Environment.NewLine +
                "¿Quien debe inscribirse?: Nos ayuda a identificar quienes deben de estar inscritos en el RUC.";

            MensajeEmergente.Mostrar(texto, "Ayuda - Información Introductoria");
        }
    }
}
