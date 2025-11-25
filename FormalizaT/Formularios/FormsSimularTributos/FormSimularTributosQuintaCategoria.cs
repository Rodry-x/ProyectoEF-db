using FormalizaT.EstructuraDeDatos;
using FormalizaT.Utilidades;

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

        // --- Estructura de datos para tramos ---
        private class TramoImpuesto
        {
            public decimal Limite { get; set; }
            public decimal Tasa { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura de datos ingresados
                decimal sueldo = string.IsNullOrWhiteSpace(txtSueldoMensual.Text) ? 0 : decimal.Parse(txtSueldoMensual.Text);
                decimal bonificaciones = string.IsNullOrWhiteSpace(txtBonificaciones.Text) ? 0 : decimal.Parse(txtBonificaciones.Text);

                // Ingreso anual (sueldo 12 meses + bonificaciones)
                decimal ingresoAnual = (sueldo * 12) + bonificaciones;

                // UIT vigente
                decimal UIT = 5350m;

                // Base imponible = ingreso anual – 7 UIT
                decimal baseImponible = ingresoAnual - (7 * UIT);

                if (baseImponible <= 0)
                {
                    lblDetalles.Text = "El ingreso no supera las 7 UIT. No paga impuesto.";
                    lblImpuesto.Text = "Impuesto: S/. 0.00";
                    lblResultado.Text = $"Resultado neto: S/. {ingresoAnual:F2}";
                    return;
                }

                // Calcular impuesto usando ListaEnlazada
                decimal impuesto = CalcularImpuestoQuinta(baseImponible, UIT);
                decimal resultado = ingresoAnual - impuesto;
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  CALCULAR IMPUESTO 5TA  //
        private decimal CalcularImpuestoQuinta(decimal baseImponible, decimal UIT)
        {
            // Crear lista enlazada propia con los tramos
            ListaEnlazada<TramoImpuesto> tramos = new ListaEnlazada<TramoImpuesto>();

            tramos.Agregar(new TramoImpuesto { Limite = 5 * UIT, Tasa = 0.08m });
            tramos.Agregar(new TramoImpuesto { Limite = 20 * UIT, Tasa = 0.14m });
            tramos.Agregar(new TramoImpuesto { Limite = 35 * UIT, Tasa = 0.17m });
            tramos.Agregar(new TramoImpuesto { Limite = 45 * UIT, Tasa = 0.20m });
            tramos.Agregar(new TramoImpuesto { Limite = decimal.MaxValue, Tasa = 0.30m });

            decimal impuesto = 0m;
            decimal anterior = 0m;

            // Para detallar cada tramo
            string detalleTramos = "Detalle por tramos:\n";

            var nodo = tramos.Inicio;

            while (nodo != null)
            {
                var tramo = nodo.Valor;
                decimal montoTramo = 0m;

                if (baseImponible <= tramo.Limite)
                {
                    montoTramo = (baseImponible - anterior);
                    if (montoTramo > 0)
                        impuesto += montoTramo * tramo.Tasa;

                    // Registrar detalle
                    detalleTramos +=
                        $"Hasta {tramo.Limite:N2} (tasa {tramo.Tasa:P0}): S/. {(montoTramo * tramo.Tasa):N2}\n";

                    break;
                }
                else
                {
                    montoTramo = (tramo.Limite - anterior);
                    if (montoTramo > 0)
                        impuesto += montoTramo * tramo.Tasa;

                    // Registrar detalle
                    detalleTramos +=
                        $"Hasta {tramo.Limite:N2} (tasa {tramo.Tasa:P0}): S/. {(montoTramo * tramo.Tasa):N2}\n";

                    anterior = tramo.Limite;
                }

                nodo = nodo.Siguiente;
            }

            // Mostrar detalle en la etiqueta lblDetalles (se concatena al texto ya asignado)
            lblDetalles.Text += "\n\n" + detalleTramos;

            return impuesto;
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            var texto =
                "Ayuda — Simulación 5ª categoría:" + Environment.NewLine +
                "- Entradas:" + Environment.NewLine +
                "  • Sueldo mensual: salario por mes." + Environment.NewLine +
                "  • Bonificaciones: pagos extraordinarios anuales." + Environment.NewLine +
                "- Cálculo:" + Environment.NewLine +
                "  1) Ingreso anual = Sueldo mensual × 12 + Bonificaciones." + Environment.NewLine +
                "  2) Base imponible = Ingreso anual − 7 UIT (UIT usada: 5350)." + Environment.NewLine +
                "  3) Si la base imponible ≤ 0 ⇒ no paga impuesto." + Environment.NewLine +
                "  4) Si es positiva, se aplica el impuesto por tramos:" + Environment.NewLine +
                "     • Hasta 5 UIT → 8%" + Environment.NewLine +
                "     • Hasta 20 UIT → 14%" + Environment.NewLine +
                "     • Hasta 35 UIT → 17%" + Environment.NewLine +
                "     • Hasta 45 UIT → 20%" + Environment.NewLine +
                "     • Sobre el exceso → 30%" + Environment.NewLine +
                "- Salidas mostradas:" + Environment.NewLine +
                "  • lblImpuesto: importe total y (en el formulario) tasa efectiva." + Environment.NewLine +
                "  • lblResultado: ingreso neto después de impuesto." + Environment.NewLine +
                "  • lblDetalles: se añade un desglose por tramos con el aporte de cada tramo." + Environment.NewLine +
                "- Formato: ingresa números válidos (se admiten separadores y decimales)." + Environment.NewLine +
                "- Nota: los resultados son orientativos; verifica normativa vigente y posibles redondeos." + Environment.NewLine +
                "Ejemplo rápido: Sueldo 3,000 + Bonificaciones 5,000 ⇒ Ingreso anual 41,000; Base imponible = 41,000 − 37,450 = 3,550 (se aplica 8% sobre esa base).";

            MensajeEmergente.Mostrar(texto, "Ayuda - Simulación 5ta categoría");
        }
    }
}