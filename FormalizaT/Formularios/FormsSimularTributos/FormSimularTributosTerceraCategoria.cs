using FormalizaT.EstructuraDeDatos;
using FormalizaT.Utilidades;
using System.Globalization;

namespace FormalizaT.Formularios.FormsSimularTributos
{
    public partial class FormSimularTributosTerceraCategoria : Form
    {
        public FormSimularTributosTerceraCategoria()
        {
            InitializeComponent();
            InicializarRegimenes();
        }

        private FormSimularTributos formSimularTributos;

        // Diccionario para almacenar tasas base de regímenes
        private readonly Dictionary<string, decimal> regimenes = new Dictionary<string, decimal>();

        // Valor referencial de la UIT 2025 (según SUNAT)
        private const decimal UIT = 5350m;

        public Panel TerceraCategoria => panelSimularTributosTerceraCategoria;

        private void cambiarAlPanelSimularTributos(object sender, EventArgs e)
        {
            formSimularTributos = new FormSimularTributos();
            PanelController.CambiarPanel(panelSimularTributosTerceraCategoria, formSimularTributos.PanelSimularTributosControl);
        }

        private void InicializarRegimenes()
        {
            regimenes.Add("RUS (Simplificado)", 0.01m);   // Aprox. 1%
            regimenes.Add("RER (Especial)", 0.015m);      // Aprox. 1.5%
            regimenes.Add("MYPE Tributario", 0.10m);      // 10% hasta 15 UIT
            regimenes.Add("Régimen General", 0.295m);     // 29.5%

            cmbRegimenes.Items.Clear();
            foreach (var key in regimenes.Keys)
                cmbRegimenes.Items.Add(key);
        }

        // Clase para tramos
        private class Tramo
        {
            public decimal Limite { get; set; }
            public decimal Tasa { get; set; }
        }

        private ListaEnlazada<Tramo> CrearListaTramosTerceraCategoria()
        {
            decimal UIT = 5350m; // UIT para 2025 según tu uso

            var lista = new ListaEnlazada<Tramo>();

            // Tramos según SUNAT tramos IR 2025
            lista.Agregar(new Tramo { Limite = 5 * UIT, Tasa = 0.08m });
            lista.Agregar(new Tramo { Limite = 20 * UIT, Tasa = 0.14m });
            lista.Agregar(new Tramo { Limite = 35 * UIT, Tasa = 0.17m });
            lista.Agregar(new Tramo { Limite = 45 * UIT, Tasa = 0.20m });
            lista.Agregar(new Tramo { Limite = decimal.MaxValue, Tasa = 0.30m });

            return lista;
        }

        private decimal CalcularImpuestoTerceraCategoria(decimal utilidad)
        {
            // utilidad: ingreso neto (o base imponible)
            var tramos = CrearListaTramosTerceraCategoria();
            var nodo = tramos.Inicio;

            while (nodo != null)
            {
                if (utilidad <= nodo.Valor.Limite)
                {
                    return utilidad * nodo.Valor.Tasa;
                }
                nodo = nodo.Siguiente;
            }

            return 0m;
        }

        private void simularImporte_Click(object sender, EventArgs e)
        {
            string textoIngresos = txtMontoBruto.Text?.Trim() ?? string.Empty;
            string textoGastos = txtMontoNeto.Text?.Trim() ?? string.Empty;

            if (!decimal.TryParse(textoIngresos, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                    CultureInfo.CurrentCulture, out decimal ingresos) ||
                !decimal.TryParse(textoGastos, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                    CultureInfo.CurrentCulture, out decimal gastos))
            {
                lblResultados.Text = "Ingrese valores válidos para ingresos y gastos.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            decimal utilidad = ingresos - gastos;
            if (utilidad < 0)
            {
                lblResultados.Text = "Pérdida: los gastos superan los ingresos.";
                lblImpuesto.Text = string.Empty;
                return;
            }

            decimal impuesto = CalcularImpuestoTerceraCategoria(utilidad);
            decimal resultado = utilidad - impuesto;

            lblImpuesto.Text = $"Impuesto: {impuesto.ToString("C2", CultureInfo.CurrentCulture)}";
            lblResultados.Text = $"Utilidad neta después de impuesto: {resultado.ToString("C2", CultureInfo.CurrentCulture)}";
        }

        private void txtMontoBruto_TextChanged(object sender, EventArgs e)
        {
            lblResultados.Text = string.Empty;
            lblImpuesto.Text = string.Empty;
        }

        private void txtMontoNeto_TextChanged(object sender, EventArgs e)
        {
            lblResultados.Text = string.Empty;
            lblImpuesto.Text = string.Empty;
        }

        private void cmbRegimenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultados.Text = string.Empty;
            lblImpuesto.Text = string.Empty;
        }
    }
}
