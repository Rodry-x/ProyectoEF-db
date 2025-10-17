namespace FormalizaT.Utilidades

{
    internal class PanelController
    {
        // ---- Método para cambiar el panel mostrado en un contenedor ---- //
        public static void CambiarPanel(Panel panelContenedor, Panel nuevoPanel)
        {
            // ---- Limpiar el panel contenedor y agregar el nuevo panel ---- //
            panelContenedor.Controls.Clear();
            nuevoPanel.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(nuevoPanel);
        }
    }
}