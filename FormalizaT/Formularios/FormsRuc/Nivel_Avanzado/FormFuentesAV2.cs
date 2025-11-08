

using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormFuentesAV2 : Form
    {
        public FormFuentesAV2()
        {
            InitializeComponent();
        }
        public Panel PanelFuentesAV2Control => panelFormFuentes_Int;
        private FormFuentesAV formFuentesAV;
        private FormFuentesAV3 formFuentesAV3;

        private void cambiarAlPanelFuentes1_Click(object sender, EventArgs e)
        {
            formFuentesAV = new FormFuentesAV();
            PanelController.CambiarPanel(panelFormFuentes_Int, formFuentesAV.PanelFuentesAVControl);
        }

        private void cambiarAlPanelFuentes3_Click(object sender, EventArgs e)
        {
            formFuentesAV3 = new FormFuentesAV3();
            PanelController.CambiarPanel(panelFormFuentes_Int, formFuentesAV3.PanelFuentesAV3Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.producempresarial.pe/wp-content/uploads/2025/03/268-Reporte-de-Factoring-DIC-2024.pdf");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.cajaarequipa.pe/negocios/linea-de-credito/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bbva.pe/empresas/productos/financiamiento.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.scotiabank.com.pe/pyme-negocios/financiamiento/default");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.cajaarequipa.pe/negocios/credito-capital-de-trabajo/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.cofide.com.pe/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.viabcp.com/empresas/financiamiento/financiamiento-empresarial");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://bizlinks.com.pe/facturacion-electronica-en-peru-guia-definitiva-para-empresas-b2b/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://tandiashop.com/blog/sunat-y-la-obligacion-de-emitir-comprobantes-electronicos/");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://noticierocontable.com/obligacion-emitir-comprobantes-electronicos/");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://titoperalta.com/boletin/la-facturacion-electronica-en-el-peru/");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.groupseres.com/es-pe/factura-electronica-obligatoria-peru");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/7309-emitir-factura-electronica-sistema-de-emision-electronica-sol");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://edicom.co/blog/como-es-la-factura-electronica-peru");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/25781-municipalidad-provincial-de-canete-obtener-licencia-de-funcionamiento-para-negocios-de-riesgo-bajo-o-medio");
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://gestion.pe/economia/minam-luz-verde-para-permisos-ambientales-ahora-con-nuevos-procedimientos-senace-certificacion-ambiental-noticia/");
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://titoperalta.com/blog/que-licencias-y-permisos-necesito-para-comenzar-a-operar-en-peru/");
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://gepresac.pe/servicios/sectoriales_subsectoriales/");
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("http://www.crecemype.pe/Crecemype/LicenciaMunicipal.php");
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://revistaimpulso.org/index.php/impulso/article/view/652");
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://revistas.pucp.edu.pe/index.php/revistalidera/article/download/28558/26323/113593");
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("http://www.scielo.org.bo/scielo.php?script=sci_arttext&pid=S2959-90402025000300347");
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("http://eulacfoundation.org/es/peru-responsable-programa-nacional-promocion-la-rse");
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://rse.pe/");
        }
    }
}
