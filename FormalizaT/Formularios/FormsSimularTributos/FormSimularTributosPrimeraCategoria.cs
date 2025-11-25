using FormalizaT.Utilidades;
using FormalizaT.EstructuraDeDatos;
using System.Globalization;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosPrimeraCategoria : Form
    {
        public FormSimularTributosPrimeraCategoria()
        {
            InitializeComponent();
        }

        private FormSimularTributos formSimularTributos;
        public Panel PrimeraCategoria => panelSimularTributosPrimeraCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosPrimeraCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        // ----------- ESTRUCTURA CON LISTA ENLAZADA -----------
        private class Tramo
        {
            public decimal Limite { get; set; }
            public decimal Tasa { get; set; }
        }

        private ListaEnlazada<Tramo> CrearListaTramos(decimal tasaUnica)
        {
            var lista = new ListaEnlazada<Tramo>();
            lista.Agregar(new Tramo
            {
                Limite = decimal.MaxValue,
                Tasa = tasaUnica
            });
            return lista;
        }

        private void simularImporte_Click(object sender, EventArgs e)
        {
            string texto = txtMonto.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(texto))
            {
                lblResultado.Text = "Ingrese un monto válido.";
                lblImpuesto.Text = string.Empty;
                lblAdicional.Text = string.Empty;
                return;
            }

            if (!decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                CultureInfo.CurrentCulture, out decimal monto))
            {
                lblResultado.Text = "Formato inválido.";
                lblImpuesto.Text = string.Empty;
                lblAdicional.Text = string.Empty;
                return;
            }

            if (monto <= 0)
            {
                lblResultado.Text = "El monto debe ser mayor que cero.";
                lblImpuesto.Text = string.Empty;
                lblAdicional.Text = string.Empty;
                return;
            }

            // Crear lista enlazada con la tasa de Primera Categoría (5%)
            decimal tasa = 0.05m;
            var listaTramos = CrearListaTramos(tasa);

            // Calcular impuesto usando la lista enlazada
            decimal impuesto = 0m;
            var nodo = listaTramos.Inicio;
            if (nodo != null)
            {
                impuesto = monto * nodo.Valor.Tasa;
            }


            decimal neto = monto - impuesto;

            // Mostrar resultados
            lblResultado.Text = neto.ToString("C2", CultureInfo.CurrentCulture);
            lblImpuesto.Text = impuesto.ToString("C2", CultureInfo.CurrentCulture);
            lblAdicional.Text = "Cálculo correcto para Primera Categoría (5%).";
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            var texto = "Simulación de Tributos - Primera Categoría:\n\n" +
                        "Ingrese el monto de ingresos para calcular el impuesto correspondiente a la Primera Categoría, " +
                        "que tiene una tasa fija del 5% sobre los ingresos netos. " +
                        "El sistema calculará automáticamente el impuesto y el monto neto después del impuesto.";

            MensajeEmergente.Mostrar(texto, "Ayuda - Simulación de Tributos Primera Categoría");
        }
    }
}