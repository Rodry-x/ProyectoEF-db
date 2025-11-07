using FormalizaT.Utilidades;
using FormalizaT.Formularios.FormsRuc;
using FormalizaT.Formularios.FormsRuc.Nivel_Introductorio;
using System;
using System.Windows.Forms;

namespace FormalizaT.Formularios
{
    public partial class FormInformacionIntermedia : Form
    {
        public FormInformacionIntermedia()
        {
            InitializeComponent();
        }

        private FormPasosParaFormalizar formPasosParaFormalizar;
        private FormRegimenesTributarios formRegimenesTributarios;
        private FormDeclaracionesYPagosMensuales formDeclaracionesYPagosMensuales;
        private FormEmisiónComprobantesElectrónicos formEmisiónComprobantesElectrónicos;
        private FormClaveSOLySUNATVirtual formClaveSOLySUNATVirtual;
        private FormObligacionesContables formObligacionesContables;
        private FormMultasySanciones formMultasySanciones;
        private FormPlanilla formPlanilla;
        private FormSeguridadSocial formSeguridadSocial;
        private FormEducaciónFinanciera formEducaciónFinanciera;
        private FormFuentes_int formFuentes_Int;


        public Panel PanelInformacionIntermediaControl => panelInformacionIntermedia;

        private void cambiarAlPanelPasosParaFormalizar_Click(object sender, EventArgs e)
        {
            formPasosParaFormalizar = new FormPasosParaFormalizar();
            PanelController.CambiarPanel(panelInformacionIntermedia, formPasosParaFormalizar.PanelPasosParaFormalizarControl);
        }

        private void cambiarAlPanelRegimenesTributarios(object sender, EventArgs e)
        {
            formRegimenesTributarios = new FormRegimenesTributarios();
            PanelController.CambiarPanel(panelInformacionIntermedia, formRegimenesTributarios.PanelRegimenesTributariosControl);
        }

        private void cambiarAlPanelDeclaracionesYPagosMensuales(object sender, EventArgs e)
        {
            formDeclaracionesYPagosMensuales = new FormDeclaracionesYPagosMensuales();
            PanelController.CambiarPanel(panelInformacionIntermedia, formDeclaracionesYPagosMensuales.PanelDeclaracionesYPagosMensualesControl);
        }

        private void cambiarAlPanelEmisionDeComprobantes(object sender, EventArgs e)
        {
            formEmisiónComprobantesElectrónicos = new FormEmisiónComprobantesElectrónicos();
            PanelController.CambiarPanel(panelInformacionIntermedia, formEmisiónComprobantesElectrónicos.PanelEmisionComprobantesElectrónicosControl);
        }

        private void cambiarAlPanelClaveSolYSUNATVirtual(object sender, EventArgs e)
        {
            formClaveSOLySUNATVirtual = new FormClaveSOLySUNATVirtual();
            PanelController.CambiarPanel(panelInformacionIntermedia, formClaveSOLySUNATVirtual.PanelClaveSOLySUNATVirtualControl);
        }

        private void cambiarAlPanelObligacionesContables(object sender, EventArgs e)
        {
            formObligacionesContables = new FormObligacionesContables();
            PanelController.CambiarPanel(panelInformacionIntermedia, formObligacionesContables.PanelObligacionesContablesControl);
        }

        private void cambiarAlPanelMultasYSanciones(object sender, EventArgs e)
        {
            formMultasySanciones = new FormMultasySanciones();
            PanelController.CambiarPanel(panelInformacionIntermedia, formMultasySanciones.PanelMultasySancionesControl);
        }

        private void cambiarAlPanelPlanilla(object sender, EventArgs e)
        {
            formPlanilla = new FormPlanilla();
            PanelController.CambiarPanel(panelInformacionIntermedia, formPlanilla.PanelPlanillaControl);
        }

        private void cambiarAlPanelSeguridadSocial(object sender, EventArgs e)
        {
            formSeguridadSocial = new FormSeguridadSocial();
            PanelController.CambiarPanel(panelInformacionIntermedia, formSeguridadSocial.PanelSeguridadSocialControl);
        }

        private void cambiarAlPanelEducacionFinanciera(object sender, EventArgs e)
        {
            formEducaciónFinanciera = new FormEducaciónFinanciera();
            PanelController.CambiarPanel(panelInformacionIntermedia, formEducaciónFinanciera.PanelEducacionFinancieraControl);
        }

        private void cambiarAlPanelFuentes_int(object sender, EventArgs e)
        {
            formFuentes_Int = new FormFuentes_int();
            PanelController.CambiarPanel(panelInformacionIntermedia, formFuentes_Int.PanelFuentesIntControl);
        }
    }
}
