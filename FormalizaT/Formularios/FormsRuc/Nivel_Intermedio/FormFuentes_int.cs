
using FormalizaT.Formularios.FormsRuc.Nivel_Intermedio;
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormFuentes_int : Form
    {
        public FormFuentes_int()
        {
            InitializeComponent();
        }

        public Panel PanelFuentesIntControl => panelFormFuentes_Int;
        private FormFuentes_int2 formFuentesInt2;

        private FormInformacionIntermedia formInformacionIntermedia;

        private void cambiarAlPanelIntermedio_Click(object sender, EventArgs e)
        {
            formInformacionIntermedia = new FormInformacionIntermedia();
            PanelController.CambiarPanel(panelFormFuentes_Int, formInformacionIntermedia.PanelInformacionIntermediaControl);
        }

        private void cambiarAlPanelFuentes2_Click(object sender, EventArgs e)
        {
            formFuentesInt2 = new FormFuentes_int2();
            PanelController.CambiarPanel(panelFormFuentes_Int, formFuentesInt2.PanelFuentes_int2Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.interseguro.pe/blog/pasos-constituir-empresa-peru");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://lpderecho.pe/como-constituir-empresa-aspectos-practicos-formalizacion-empresa/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://tusocio.proponte.com.pe/pasos-para-formalizar-una-empresa/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.sunat.gob.pe/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.prestamype.com/articulos/regimenes-tributarios-que-son-y-cuantos-existen");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://cgrlawyer.pe/regimenes-tributarios-nrus-vs-rer-vs-rmt/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/ruc/regimenes-tributarios-mype/regimenes-tributarios");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/1209-conocer-el-regimen-tributario-para-mi-negocio");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/8056-declara-facil-de-sunat");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/declaracion-pagos/declaracion/medios-para-declarar-pagar");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/684-consultar-declaraciones-y-pagos-a-sunat");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.sunat.gob.pe/orientacion/cronogramas/2025/cObligacionMensual2025.html");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/13-condiciones-para-incorporarse-el-sistema-de-emision-electronica");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://edicom.co/blog/como-es-la-factura-electronica-peru");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://cpe.sunat.gob.pe/informacion_general/obligados_cpe");
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/7309-emitir-factura-electronica-sistema-de-emision-electronica-sol");
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/02-obtencion-de-clave-sol");
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/3315-como-ingresar-acceder-a-sunat-operaciones-en-linea-personas");
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.youtube.com/watch?v=mSQWtJFxnU4");
        }
    }
}
