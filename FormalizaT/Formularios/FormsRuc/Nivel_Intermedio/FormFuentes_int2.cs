using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Intermedio
{
    public partial class FormFuentes_int2 : Form
    {
        public FormFuentes_int2()
        {
            InitializeComponent();
        }
        public Panel PanelFuentes_int2Control => panelFormFuentes_Int;
        private FormFuentes_int formFuentes_Int;

        private void cambiarAlPanelFuentes_Click(object sender, EventArgs e)
        {
            formFuentes_Int = new FormFuentes_int();
            PanelController.CambiarPanel(panelFormFuentes_Int, formFuentes_Int.PanelFuentesIntControl);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://revistaganamas.com.pe/sunat-cuales-son-las-obligaciones-tributarias-que-debe-cumplir-mi-empresa/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/1211-llevar-libros-contables-para-mi-negocio");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/libros-y-registros-obligatorios");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/comprobantes-libros/registros-libros-electronicos/libros-registros-contables-obligatorios");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://dfacturacion.com/consejos-tributarios-para-evitar-problemas-con-sunat/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.mef.gob.pe/defensoria/boletines/Exp_defensoria_06052022.pdf");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://symcontadores.com/tipos-de-infracciones-tributarias/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/acciones-sunat/facultad-sancionadora/regimen-gradualidad");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/09-multas-e-infracciones");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/8071-planilla-electronica");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/informacion-general-planilla-electronica");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/principales-impuestos/planilla/planilla-electronica");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://lpderecho.pe/que-es-planilla-electronica-plame/");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/essalud");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/12947-consultar-si-tu-seguro-essalud-esta-activo");
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.poderosa.com.pe/Content/img/publicaciones/06-boletines-informativos/seguro-social-de-salud.pdf");
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bbva.com/es/salud-financiera/que-son-los-egresos-e-ingresos-y-que-tipos-existen/");
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://futuraschools.edu.pe/blog/categoria/futura-talks/finanzas-personales-para-adolescentes-control-de-ingresos-gastos-y-ahorros");
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.sbs.gob.pe/portals/3/educacion-financiera-pdf/guia_domina_tus_finanzas.pdf");
        }
    }
}
