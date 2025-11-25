using FormalizaT.EstructuraDeDatos;
using FormalizaT.Utilidades;
using System.Globalization;
using System.Text;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosSegundaCategoria : Form
    {
        private ListaEnlazada<string> historialSegundaCategoria = new ListaEnlazada<string>();

        public FormSimularTributosSegundaCategoria()
        {
            InitializeComponent();
        }

        private FormSimularTributos formSimularTributos;

        public Panel SegundaCategoria => panelSimularTributoSegundaCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributoSegundaCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        //  ESTRUCTURA DE TRAMOS  //

        private class Tramo
        {
            public decimal Limite { get; set; } // Límite superior del tramo
            public decimal Tasa { get; set; }   // Porcentaje de impuesto del tramo
        }

        private ListaEnlazada<Tramo> CrearTramosSegundaCategoria()
        {
            decimal UIT = 5150m;
            var lista = new ListaEnlazada<Tramo>();

            // TRAMO 1 → Hasta 5 UIT (8%)
            lista.Agregar(new Tramo
            {
                Limite = 5 * UIT,
                Tasa = 0.08m
            });

            // TRAMO 2 → Hasta 20 UIT (14%)
            lista.Agregar(new Tramo
            {
                Limite = 20 * UIT,
                Tasa = 0.14m
            });

            // TRAMO 3 → Más de 20 UIT (30%)
            lista.Agregar(new Tramo
            {
                Limite = decimal.MaxValue,
                Tasa = 0.30m
            });

            return lista;
        }

        private decimal CalcularImpuestoSegundaCategoria(decimal monto)
        {
            var tramos = CrearTramosSegundaCategoria();
            var nodo = tramos.Inicio;

            while (nodo != null)
            {
                if (monto <= nodo.Valor.Limite)
                {
                    return monto * nodo.Valor.Tasa;
                }
                nodo = nodo.Siguiente;  // Avanzar por la lista enlazada
            }

            return 0m; // Nunca debería llegar aquí
        }

        //  EVENTO DE SIMULACIÓN  //  

        private void simularImporte_Click(object sender, EventArgs e)
        {
            var impuestoBuilder = new StringBuilder();
            var resultadoBuilder = new StringBuilder();
            bool anyValue = false;

            // Procesar txtMontoBruto (8%, 14%, 30% según tramos)
            if (!string.IsNullOrWhiteSpace(txtMontoBruto.Text))
            {
                if (!decimal.TryParse(txtMontoBruto.Text.Trim(), NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal montoBruto))
                {
                    lblResultados.Text = "Formato de monto inválido en 'Monto Bruto'.";
                    lblImpuesto.Text = string.Empty;
                    return;
                }

                decimal impuestoBruto = CalcularImpuestoSegundaCategoria(montoBruto);
                decimal resultadoBruto = montoBruto - impuestoBruto;

                impuestoBuilder.AppendLine($"Bruto: {impuestoBruto.ToString("C2", CultureInfo.CurrentCulture)}");
                resultadoBuilder.AppendLine($"Bruto: {resultadoBruto.ToString("C2", CultureInfo.CurrentCulture)}");
                anyValue = true;

                historialSegundaCategoria.Agregar($"Monto Bruto: {montoBruto.ToString("C2", CultureInfo.CurrentCulture)} | Impuesto: {impuestoBruto.ToString("C2", CultureInfo.CurrentCulture)} | Resultado: {resultadoBruto.ToString("C2", CultureInfo.CurrentCulture)}");
            }

            // Procesar txtMontoNeto (puedes aplicar la misma lógica de tramos o una tasa fija si corresponde)
            if (!string.IsNullOrWhiteSpace(txtMontoNeto.Text))
            {
                if (!decimal.TryParse(txtMontoNeto.Text.Trim(), NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal montoNeto))
                {
                    lblResultados.Text = "Formato de monto inválido en 'Monto Neto'.";
                    lblImpuesto.Text = string.Empty;
                    return;
                }

                // Si el neto tiene una tasa diferente, cámbiala aquí. Ejemplo: 6.25%
                decimal impuestoNeto = montoNeto * 0.0625m;
                decimal resultadoNeto = montoNeto - impuestoNeto;

                impuestoBuilder.AppendLine($"Neto: {impuestoNeto.ToString("C2", CultureInfo.CurrentCulture)}");
                resultadoBuilder.AppendLine($"Neto: {resultadoNeto.ToString("C2", CultureInfo.CurrentCulture)}");
                anyValue = true;

                historialSegundaCategoria.Agregar($"Monto Neto: {montoNeto.ToString("C2", CultureInfo.CurrentCulture)} | Impuesto: {impuestoNeto.ToString("C2", CultureInfo.CurrentCulture)} | Resultado: {resultadoNeto.ToString("C2", CultureInfo.CurrentCulture)}");
            }

            if (!anyValue)
            {
                lblResultados.Text = "Ingrese un monto.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            // Mostrar resultados finales
            lblImpuesto.Text = impuestoBuilder.ToString().TrimEnd();
            lblResultados.Text = resultadoBuilder.ToString().TrimEnd();
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            var texto =
                "Simulación - Segunda Categoría:\n" +
                "- Monto Bruto: introduce el total antes de impuestos. Se aplican tramos:\n" +
                "  • Hasta 5 UIT → 8%\n" +
                "  • Hasta 20 UIT → 14%\n" +
                "  • Más de 20 UIT → 30%\n" +
                "- Monto Neto: introduce el monto neto; por defecto se aplica una tasa de ejemplo (6.25%).\n" +
                "- Resultados: 'Impuesto' muestra el monto calculado; 'Resultado' es lo que queda después de restar el impuesto.\n" +
                "- Formato: usa números; se admiten separadores y símbolo de moneda (ej. 1500 o 1,500.00).\n" +
                "- Historial: cada simulación se guarda en el historial local para consultas posteriores.\n" +
                "Nota: las tasas son orientativas. Verifica la normativa vigente para valores oficiales.";

            MensajeEmergente.Mostrar(texto, "Ayuda - Simulación de Tributos Segunda Categoría");
        }
    }
}