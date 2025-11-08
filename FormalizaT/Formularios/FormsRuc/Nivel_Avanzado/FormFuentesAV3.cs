
using FormalizaT.Utilidades;

namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    public partial class FormFuentesAV3 : Form
    {
        public FormFuentesAV3()
        {
            InitializeComponent();
        }
        public Panel PanelFuentesAV3Control => panelFuentes;
        private FormFuentesAV2 formFuentesAV2;

        private void cambiarAlPanelFuente2_Click(object sender, EventArgs e)
        {
            formFuentesAV2 = new FormFuentesAV2();
            PanelController.CambiarPanel(panelFuentes, formFuentesAV2.PanelFuentesAV2Control);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.lidercontab.com/constitucion-de-sucursal-de-empresa-extranjera-en-peru/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.bizlatinhub.com/es/paso-establecer-sucursal-de-empresa-peru/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.ebsabogados.com/abrir-sucursal-empresa-extranjera-peru/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.gob.pe/89359-solicitar-apertura-de-sucursales-oficinas-centros-de-trabajo-u-otros-establecimientos-de-las-entidades-que-desarrollan-actividades-de-intermediacion-laboral");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://tvperu.gob.pe/noticias/economia/sucursal-o-subsidiaria-conoce-la-mejor-opcion-para-expandir-tu-negocio");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://orientacion.sunat.gob.pe/3123-tipos-de-fiscalizacion-personas");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://quantumconsultores.com/auditoria-tributaria-preventiva-sunat-2025/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://noticierocontable.com/fiscalizacion-tributaria/");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://emprender.sunat.gob.pe/acciones-sunat/facultad-fiscalizacion/facultad-fiscalizacion");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.infobae.com/peru/2025/07/22/la-demanda-de-auditores-tributarios-en-peru-alcanza-niveles-historicos-ante-el-endurecimiento-de-controles-de-la-sunat-revela-quantum/");
        }
    }
}
