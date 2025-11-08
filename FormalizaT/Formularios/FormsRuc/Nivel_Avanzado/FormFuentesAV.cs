
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormFuentesAV : Form
    {
        public FormFuentesAV()
        {
            InitializeComponent();
        }
        public Panel PanelFuentesAVControl => panelFormFuentes_Int;
        private FormInformacionAvanzada formInformacionAvanzada;
        private FormFuentesAV2 formFuentesAV2;

        private void cambiarAlPanelInformacionAvanzada_Click(object sender, EventArgs e)
        {
            formInformacionAvanzada = new FormInformacionAvanzada();
            PanelController.CambiarPanel(panelFormFuentes_Int, formInformacionAvanzada.PanelInformacionAvanzadaControl);
        }

        private void cambiarAlPanelFuente2_Click(object sender, EventArgs e)
        {
            formFuentesAV2 = new FormFuentesAV2();
            PanelController.CambiarPanel(panelFormFuentes_Int, formFuentesAV2.PanelFuentesAV2Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.esan.edu.pe/conexion-esan/que-es-el-planeamiento-tributario-y-que-se-requiere-para-implementarlo");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://ve.scielo.org/pdf/erms/v3/2960-2467-erms-3-e-RMS24022025.pdf");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://repositorio.uncp.edu.pe/handle/20.500.12894/6318");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://dspace.uazuay.edu.ec/bitstream/datos/11311/1/16848.pdf");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.mef.gob.pe/contenidos/conta_publ/capacitaciones/exposiciones/f_efectivo_12122016.pdf");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://getquipu.com/blog/estado-flujos-efectivo/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bbva.com/es/salud-financiera/estados-financieros-que-son-y-por-que-son-tan-importantes-para-una-empresa-o-pyme/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://blogposgrado.ucontinental.edu.pe/diferencias-entre-estado-de-resultado-y-el-flujo-de-caja/");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.mef.gob.pe/contenidos/conta_publ/con_nor_co/NIC07_04.pdf");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://salaris.pe/tipos-de-contratos-laboral/");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://peru.universidadeuropea.com/blog/tipos-contratos/");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://peru.unir.net/revista/derecho/tipos-contratos-peru/");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.deel.com/es/blog/tipos-de-contratos-en-peru/");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://lpderecho.pe/tipos-contratos-trabajo-contratacion-directa/");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://vega-abogados.com.pe/contrato-laboral-conoce-las-opciones-que-existen-en-peru/");
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/institucion/mtpe/colecciones/61982-modelos-y-formatos-referenciales-del-tupa-vigente-del-mtpe");
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/333-registrar-la-marca-de-producto-o-servicio-de-tu-negocio-en-indecopi");
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://dafo.cultura.pe/indecopi-pone-a-disposicion-plataforma-virtual-para-el-registro-de-obras-protegidas-por-el-derecho-de-autor/");
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://pi.indecopi.gob.pe/buscatumarca/");
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://servicio.indecopi.gob.pe/buscadorResoluciones/propiedad-intelectual.seam");
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.youtube.com/watch?v=ykMdEsa-2uI");
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.youtube.com/watch?v=3QGOrWdMPZY");
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.youtube.com/watch?v=BdwfH7ceiWU");
        }
    }
}
