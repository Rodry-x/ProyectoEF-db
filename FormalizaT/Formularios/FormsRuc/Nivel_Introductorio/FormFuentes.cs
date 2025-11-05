using FormalizaT.Formularios.FormsRuc.Nivel_Introductorio;
using FormalizaT.Utilidades;
using System;

namespace FormalizaT.Formularios.FormsRuc
{
    public partial class FormFuentes : Form
    {
        public FormFuentes()
        {
            InitializeComponent();
        }

        private FormInformacionBasica formInformacionBasica;
        private FormFuentes2 formFuentes2;
        public Panel PanelFuentesControl => panelFuentes;
        private void cambiarAlPanelInformacionBasica_Click(object sender, EventArgs e)
        {
            formInformacionBasica = new FormInformacionBasica();
            PanelController.CambiarPanel(panelFuentes, formInformacionBasica.PanelInformacionBasicaControl);
        }
        private void cambiarAlPanelFuentes2_Click(object sender, EventArgs e)
        {
            formFuentes2 = new FormFuentes2();
            PanelController.CambiarPanel(panelFuentes, formFuentes2.PanelFuentes2Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bizlatinhub.com/es/que-es-el-ruc/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.prestamype.com/articulos/que-es-el-ruc-y-para-que-sirve");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bbva.pe/blog/mi-empresa/mype/que-es-ruc-porque-es-importante.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://blog.yimiglobal.com/que-es-el-ruc-en-peru/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://sercofi.pe/tipos-de-ruc-en-peru-persona-natural-y-persona-juridica/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.infobae.com/peru/2023/06/22/sunat-cuales-son-los-tipos-de-ruc-y-que-significan/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://kambista.com/evergreen/consultar-ruc-de-una-empresa-o-persona/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://totalserviciosfinancieros.com.pe/noticias/ficha-ruc-sunat/");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://lacamara.pe/como-consultar-tu-ruc-usando-tu-dni-peru/");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/565-consultar-el-estado-del-ruc");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/FrameCriterioBusquedaWeb.jsp");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/284-inscripcion-en-el-ruc");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://interbank.pe/blog/mi-vida-profesional/como-obtener-el-ruc");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/276-inscripcion-al-ruc-para-persona-juridica");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/1097-0-inscribete-en-el-ruc");
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://ww1.sunat.gob.pe/a/html/contribuyente2/registro/adminforuc/registroruc/informativo.html");
        }
    }
}
