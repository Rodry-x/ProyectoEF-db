namespace FormalizaT.Formularios.FormsSimularTributos
{
    partial class FormSimularTributosQuintaCategoria
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
            panelSimularTributosQuintaCategoria = new Panel();
            label1 = new Label();
            button1 = new Button();
            panelSimularTributosQuintaCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelSimularTributosQuintaCategoria
            // 
            panelSimularTributosQuintaCategoria.Controls.Add(button1);
            panelSimularTributosQuintaCategoria.Controls.Add(label1);
            panelSimularTributosQuintaCategoria.Location = new Point(6, 4);
            panelSimularTributosQuintaCategoria.Name = "panelSimularTributosQuintaCategoria";
            panelSimularTributosQuintaCategoria.Size = new Size(630, 530);
            panelSimularTributosQuintaCategoria.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(74, 17);
            label1.Name = "label1";
            label1.Size = new Size(449, 35);
            label1.TabIndex = 2;
            label1.Text = "Simular Tributo De Quinta Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(14, 469);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // FormSimularTributosQuintaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelSimularTributosQuintaCategoria);
            Name = "FormSimularTributosQuintaCategoria";
            Text = "FormSimularTributosQuintaCategoria";
            panelSimularTributosQuintaCategoria.ResumeLayout(false);
            panelSimularTributosQuintaCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributosQuintaCategoria;
        private Label label1;
        private Button button1;
    }
}