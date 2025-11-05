using FormalizaT.Utilidades;
using System;


namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    public partial class FormFuentes3 : Form
    {
        public FormFuentes3()
        {
            InitializeComponent();
        }
        private FormFuentes2 formFuentes2;
        public Panel PanelFuentes3Control => panelFuentes3;
        private void cambiarAlPanelFuentes2_Click(object sender, EventArgs e)
        {
            formFuentes2 = new FormFuentes2();
            PanelController.CambiarPanel(panelFuentes3, formFuentes2.PanelFuentes2Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://diariooficial.elperuano.pe/Normas/obtenerDocumento?idNorma=90009");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bbva.com/es/pe/salud-financiera/tributos-en-el-peru-que-son-que-tipos-hay-y-como-funciona-el-sistema-tributario/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.sunat.gob.pe/institucional/quienessomos/sistematributario_entiende.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.mef.gob.pe/defensoria/boletines/glosario_tributario.pdf");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.sunat.gob.pe/menu/ayuda/claveSOL.htm");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://elcomercio.pe/respuestas/sunat-que-es-la-clave-sol-para-que-sirve-y-como-puedes-obtenerla-tramites-revtli-tdex-noticia/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/393-obtener-clave-sol");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/6613-01-concepto-de-clave-sol");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://programas.ceduca.edu.pe/blog/que-son-los-comprobantes-de-pago/");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/8334-ticket-o-comprobante-de-pago-valido");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/26395-tipos-de-comprobante-de-pago-electronicos");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://sercofi.pe/que-es-el-comprobante-de-pago-y-que-tipos-existen-en-peru/");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/tipos-de-comprobantes-de-pago-fisicos-empresas");
        }
    }
}
