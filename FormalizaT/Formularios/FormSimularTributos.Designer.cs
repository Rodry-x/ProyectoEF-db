namespace FormalizaT.Formularios
{
    partial class FormSimularTributos
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
            panelSimularTributos = new Panel();
            SuspendLayout();
            // 
            // panelSimularTributos
            // 
            panelSimularTributos.Location = new Point(7, 4);
            panelSimularTributos.Name = "panelSimularTributos";
            panelSimularTributos.Size = new Size(630, 530);
            panelSimularTributos.TabIndex = 0;
            // 
            // FormSimularTributos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 541);
            Controls.Add(panelSimularTributos);
            Name = "FormSimularTributos";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributos;
    }
}