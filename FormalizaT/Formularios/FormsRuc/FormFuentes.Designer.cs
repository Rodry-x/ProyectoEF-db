namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormFuentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFuentes = new Panel();
            SuspendLayout();
            // 
            // panelFuentes
            // 
            panelFuentes.Location = new Point(6, 5);
            panelFuentes.Name = "panelFuentes";
            panelFuentes.Size = new Size(630, 530);
            panelFuentes.TabIndex = 0;
            // 
            // FormFuentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelFuentes);
            Name = "FormFuentes";
            Text = "FormFuentes";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFuentes;
    }
}