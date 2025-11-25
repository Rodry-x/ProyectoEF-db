using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalizaT.Utilidades
{
    internal class MensajeEmergente
    {
        /// <summary>
        /// Muestra un cuadro de diálogo con un mensaje informativo.
        /// </summary>
        /// <param name="mensaje">Texto a mostrar (puede contener saltos de línea).</param>
        /// <param name="titulo">Título de la ventana.</param>
        /// <param name="icon">Icono del MessageBox.</param>
        public static void Mostrar(string mensaje, string titulo = "Información", MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
                return;

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icon);
        }
    }
}
