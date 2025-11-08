
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormInformacionAvanzada : Form
    {
        public FormInformacionAvanzada()
        {
            InitializeComponent();
        }

        public Panel PanelInformacionAvanzadaControl => panelInformacionAvanzada;
        private FormGestionTributariaAvanzada formGestionAvanzada;
        private FormGestionContableYFinanciera formGestionContableAvanzada;
        private FormGestionLaboralFormal formlaboralFormal;
        private FormINDECOPI formIndecopi;
        private FormFinanciamientoYCreditos formFinanciamientoYCreditos;
        private FormDigitalizacionDelNegocio formDigitalizacionDelNegocio;
        private FormCumplimientoLegalIntegral formCumplimientoLegalIntegral;
        private FormResponsabilidadSocial formResponsabilidadSocial;
        private FormCrecimientoYEscalamiento formCrecimientoYExpansion;
        private FormGestionDeAuditoriasTributarias formAuditoria;
        private FormFuentesAV formFuentesAV;

        private void cambiarAlPanelGestion_Click(object sender, EventArgs e)
        {
            formGestionAvanzada = new FormGestionTributariaAvanzada();
            PanelController.CambiarPanel(panelInformacionAvanzada, formGestionAvanzada.PanelGestionAvanzada);
        }

        private void cambiarAlPanelGestionContable_Click(object sender, EventArgs e)
        {
            formGestionContableAvanzada = new FormGestionContableYFinanciera();
            PanelController.CambiarPanel(panelInformacionAvanzada, formGestionContableAvanzada.PanelGestionContable);
        }

        private void cambiarAlPanelGestionFormal(object sender, EventArgs e)
        {
            formlaboralFormal = new FormGestionLaboralFormal();
            PanelController.CambiarPanel(panelInformacionAvanzada, formlaboralFormal.PanelGestionLaboralFormal);
        }

        private void cambiarAlPanelIndecopi_Click(object sender, EventArgs e)
        {
            formIndecopi = new FormINDECOPI();
            PanelController.CambiarPanel(panelInformacionAvanzada, formIndecopi.PanelIndecopiControl);
        }

        private void cambiarAlPanelFinanciamiento_Click(object sender, EventArgs e)
        {
            formFinanciamientoYCreditos = new FormFinanciamientoYCreditos();
            PanelController.CambiarPanel(panelInformacionAvanzada, formFinanciamientoYCreditos.PanelFinanciamientoYCreditos);
        }

        private void cambiarAlPanelDigital_Click(object sender, EventArgs e)
        {
            formDigitalizacionDelNegocio = new FormDigitalizacionDelNegocio();
            PanelController.CambiarPanel(panelInformacionAvanzada, formDigitalizacionDelNegocio.PanelDigitalizacion);
        }

        private void cambiarAlPanelCumplimiento_Click(object sender, EventArgs e)
        {
            formCumplimientoLegalIntegral = new FormCumplimientoLegalIntegral();
            PanelController.CambiarPanel(panelInformacionAvanzada, formCumplimientoLegalIntegral.PanelCumplimientoLegalIntegralControl);
        }

        private void cambiarAlPanelResponsabilidadSocial_Click(object sender, EventArgs e)
        {
            formResponsabilidadSocial = new FormResponsabilidadSocial();
            PanelController.CambiarPanel(panelInformacionAvanzada, formResponsabilidadSocial.PanelResponsabilidadSocialControl);
        }

        private void cambiarAlPanelCrecimiento_Click(object sender, EventArgs e)
        {
            formCrecimientoYExpansion = new FormCrecimientoYEscalamiento();
            PanelController.CambiarPanel(panelInformacionAvanzada, formCrecimientoYExpansion.PanelCrecimientoYEscalamientoControl);
        }

        private void cambiarAlPanelGestionAuditoria_Click(object sender, EventArgs e)
        {
            formAuditoria = new FormGestionDeAuditoriasTributarias();
            PanelController.CambiarPanel(panelInformacionAvanzada, formAuditoria.PanelAuditoria);
        }

        private void CambiarAlPanelFuentes_Click(object sender, EventArgs e)
        {
            formFuentesAV = new FormFuentesAV();
            PanelController.CambiarPanel(panelInformacionAvanzada, formFuentesAV.PanelFuentesAVControl);
        }
    }
}
