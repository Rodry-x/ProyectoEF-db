using FormalizaT.Formularios;
using FormalizaT.Utilidades;
using MaterialSkin;
using MaterialSkin.Controls;


namespace FormalizaT
{
    public partial class FormContenedor : MaterialForm
    {
        // ----- Campos para los formularios secundarios ----- //
        private FormPrincipal formPrincipal;
        private FormSimularTributos formSimularTributos;
        private FormConsejos formConsejos;
        private FormRuc formRuc;
        private FormBeneficios formBeneficios;

        public FormContenedor()
        {
            InitializeComponent();

            //Diseño Material Design
            var materialManager = MaterialSkinManager.Instance;
            materialManager.AddFormToManage(this);
            materialManager.Theme = MaterialSkinManager.Themes.LIGHT; // o DARK
            materialManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200,
                Accent.LightBlue200, TextShade.WHITE);

            InicializarPanelPrincipal();
        }

        private void InicializarPanelPrincipal()
        {
            formPrincipal = new FormPrincipal();
            PanelController.CambiarPanel(panelContenedor, formPrincipal.PanelPrincipalControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cambiarAlPanelSimularTributos_Click(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelContenedor, formSimularTributos.PanelSimularTributosControl);
        }

        private void cambiarAlPanelConsejos_Click(object sender, EventArgs e)
        {
            formConsejos = new FormConsejos();
            PanelController.CambiarPanel(panelContenedor, formConsejos.PanelConsejosControl);
        }

        private void cambiarAlPanelRuc_Click(object sender, EventArgs e)
        {
            formRuc = new FormRuc();
            PanelController.CambiarPanel(panelContenedor, formRuc.PanelRucControl);
        }

        private void cambiarAlPanelBeneficios_Click(object sender, EventArgs e)
        {
            formBeneficios = new FormBeneficios();
            PanelController.CambiarPanel(panelContenedor, formBeneficios.PanelBeneficiosControl);
        }
        private void enviarAlFormularioDeGoogle_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://forms.gle/hUJqukDXQEUjv9eH6");
        }

        private void cerrarAplicacion_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
