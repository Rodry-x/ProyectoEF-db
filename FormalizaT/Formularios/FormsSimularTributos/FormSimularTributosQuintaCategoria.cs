using FormalizaT.Utilidades;
using System.Globalization;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosQuintaCategoria : Form
    {
        public FormSimularTributosQuintaCategoria()
        {
            InitializeComponent();
        }

        private FormSimularTributos formSimularTributos;
        public Panel QuintaCategoria => panelSimularTributosQuintaCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosQuintaCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura de datos ingresados
                decimal sueldo = string.IsNullOrWhiteSpace(txtSueldoMensual.Text) ? 0 : decimal.Parse(txtSueldoMensual.Text);
                decimal bonificaciones = string.IsNullOrWhiteSpace(txtBonificaciones.Text) ? 0 : decimal.Parse(txtBonificaciones.Text);

                // Calcular ingreso anual
                decimal ingresoAnual = (sueldo * 12) + bonificaciones;

                // Definir UIT vigente (2025)
                decimal UIT = 5350m;

                // Calcular base imponible (descontar 7 UIT)
                decimal baseImponible = ingresoAnual - (7 * UIT);

                if (baseImponible <= 0)
                {
                    lblDetalles.Text = "El ingreso no supera las 7 UIT. No paga impuesto.";
                    lblImpuesto.Text = "Impuesto: S/. 0.00";
                    lblResultado.Text = $"Resultado neto: S/. {ingresoAnual:F2}";
                    return;
                }

                // Calcular impuesto usando estructura de datos
                decimal impuesto = CalcularImpuestoQuinta(baseImponible, UIT);
                decimal resultado = ingresoAnual - impuesto;

                lblDetalles.Text =
                    $"Ingreso anual: S/. {ingresoAnual:N2}\n" +
                    $"Base imponible (después de 7 UIT): S/. {baseImponible:N2}\n" +
                    $"Cálculo conforme a tasas progresivas SUNAT 2025.";
                lblImpuesto.Text = $"Impuesto: S/. {impuesto:N2}";
                lblResultado.Text = $"Resultado neto: S/. {resultado:N2}";
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Estructura de datos para los tramos y tasas ---
        private struct TramoImpuesto
        {
            public decimal Limite;
            public decimal Tasa;
        }

        private decimal CalcularImpuestoQuinta(decimal baseImponible, decimal UIT)
        {
            // Definir tramos según SUNAT 2025
            TramoImpuesto[] tramos = new TramoImpuesto[]
            {
                new TramoImpuesto { Limite = 5 * UIT,  Tasa = 0.08m },
                new TramoImpuesto { Limite = 20 * UIT, Tasa = 0.14m },
                new TramoImpuesto { Limite = 35 * UIT, Tasa = 0.17m },
                new TramoImpuesto { Limite = 45 * UIT, Tasa = 0.20m },
                new TramoImpuesto { Limite = decimal.MaxValue, Tasa = 0.30m }
            };

            decimal impuesto = 0;
            decimal restante = baseImponible;
            decimal anterior = 0;

            foreach (var tramo in tramos)
            {
                if (restante <= tramo.Limite)
                {
                    impuesto += (restante - anterior) * tramo.Tasa;
                    break;
                }
                else
                {
                    impuesto += (tramo.Limite - anterior) * tramo.Tasa;
                    anterior = tramo.Limite;
                }
            }

            return impuesto;
        }
    }
}