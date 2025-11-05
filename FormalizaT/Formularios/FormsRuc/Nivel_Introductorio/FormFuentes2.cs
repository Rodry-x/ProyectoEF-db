using FormalizaT.Utilidades;
using System;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormFuentes2 : Form
    {
        public FormFuentes2()
        {
            InitializeComponent();
        }
        private FormFuentes formFuentes1;
        private FormFuentes3 formFuentes3;
        public Panel PanelFuentes2Control => panelFuentes2;
        private void CambiarAlPanelFuentes1(object sender, EventArgs e)
        {
            formFuentes1 = new FormFuentes();
            PanelController.CambiarPanel(panelFuentes2, formFuentes1.PanelFuentesControl);
        }

        private void cambiarAlPanelFuentes3_Click(object sender, EventArgs e)
        {
            formFuentes3 = new FormFuentes3();
            PanelController.CambiarPanel(panelFuentes2, formFuentes3.PanelFuentes3Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.sunat.gob.pe/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/produce");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/tuempresa");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("http://especializate.usat.edu.pe/blog/ocho-razones-para-apostar-por-la-formalizacion/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/institucion/tuempresa/noticias/914295-conozca-los-6-beneficios-de-la-formalizacion-empresarial");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://soscia.pe/Consultas/beneficios-formalizacion-empresarial-frente-a-sunat/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.studocu.com/pe/document/universidad-privada-del-norte/derecho-empresarial-1/informe-t1-proceso-de-formalizacion-empresarial-en-peru/128563988");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://es.scribd.com/document/589451622/Proceso-de-Formalizacion-en-SUNAT");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www2.trabajo.gob.pe/archivos/dgt/dgpit/estudiotecnico/050916_Guia_Formalizacion_2016.pdf");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://cultura.sunat.gob.pe/sites/default/files/2021-09/Guia_secundaria.pdf");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/acciones-contribuyente/formalizacion");
        }
    }
}