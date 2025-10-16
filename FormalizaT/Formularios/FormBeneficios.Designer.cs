namespace FormalizaT.Formularios
{
    partial class FormBeneficios
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
            panelBeneficios = new Panel();
            SuspendLayout();
            // 
            // panelBeneficios
            // 
            panelBeneficios.Location = new Point(5, 3);
            panelBeneficios.Name = "panelBeneficios";
            panelBeneficios.Size = new Size(630, 530);
            panelBeneficios.TabIndex = 0;
            // 
            // FormBeneficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 540);
            Controls.Add(panelBeneficios);
            Name = "FormBeneficios";
            Text = "FormBeneficios";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBeneficios;
    }
}