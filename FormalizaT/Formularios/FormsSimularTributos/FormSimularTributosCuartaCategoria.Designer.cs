namespace FormalizaT.Formularios.FormsSimularTributos
{
    partial class FormSimularTributosCuartaCategoria
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
            panelSimularTributosCuartaCategoria = new Panel();
            pictureBox1 = new PictureBox();
            lblImpuesto = new Label();
            label5 = new Label();
            label4 = new Label();
            lblResultado = new Label();
            label3 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtMonto = new TextBox();
            label2 = new Label();
            panelSimularTributosCuartaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSimularTributosCuartaCategoria
            // 
            panelSimularTributosCuartaCategoria.Controls.Add(pictureBox1);
            panelSimularTributosCuartaCategoria.Controls.Add(lblImpuesto);
            panelSimularTributosCuartaCategoria.Controls.Add(label5);
            panelSimularTributosCuartaCategoria.Controls.Add(label4);
            panelSimularTributosCuartaCategoria.Controls.Add(lblResultado);
            panelSimularTributosCuartaCategoria.Controls.Add(label3);
            panelSimularTributosCuartaCategoria.Controls.Add(label6);
            panelSimularTributosCuartaCategoria.Controls.Add(button1);
            panelSimularTributosCuartaCategoria.Controls.Add(button2);
            panelSimularTributosCuartaCategoria.Controls.Add(label1);
            panelSimularTributosCuartaCategoria.Controls.Add(txtMonto);
            panelSimularTributosCuartaCategoria.Controls.Add(label2);
            panelSimularTributosCuartaCategoria.Location = new Point(4, 3);
            panelSimularTributosCuartaCategoria.Margin = new Padding(3, 2, 3, 2);
            panelSimularTributosCuartaCategoria.Name = "panelSimularTributosCuartaCategoria";
            panelSimularTributosCuartaCategoria.Size = new Size(551, 398);
            panelSimularTributosCuartaCategoria.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconoHelp;
            pictureBox1.Location = new Point(497, 352);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Ayuda_Click;
            // 
            // lblImpuesto
            // 
            lblImpuesto.Location = new Point(250, 276);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(263, 47);
            lblImpuesto.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 276);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 31;
            label5.Text = "impuesto a Pagar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 214);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 30;
            label4.Text = "Resultados:";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(250, 214);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(263, 42);
            lblResultado.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 176);
            label3.Name = "label3";
            label3.Size = new Size(295, 19);
            label3.TabIndex = 28;
            label3.Text = "El impuesto a pagar depende de cuanto ganas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 70);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 27;
            label6.Text = "Simular";
            // 
            // button1
            // 
            button1.Location = new Point(19, 352);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // button2
            // 
            button2.Location = new Point(365, 128);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(149, 26);
            button2.TabIndex = 26;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += simularImporte;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(70, 14);
            label1.Name = "label1";
            label1.Size = new Size(362, 28);
            label1.TabIndex = 2;
            label1.Text = "Simular Tributo De Cuarta Categoria";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(228, 94);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(287, 23);
            txtMonto.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 96);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 24;
            label2.Text = "Ingresar el monto ganado:";
            // 
            // FormSimularTributosCuartaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 404);
            Controls.Add(panelSimularTributosCuartaCategoria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSimularTributosCuartaCategoria";
            Text = "FormSimularTributosCuartaCategoria";
            panelSimularTributosCuartaCategoria.ResumeLayout(false);
            panelSimularTributosCuartaCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributosCuartaCategoria;
        private Button button1;
        private Label label1;
        private Label label6;
        private Button button2;
        private TextBox txtMonto;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private Label label5;
        private Label label4;
        private Label lblImpuesto;
        private PictureBox pictureBox1;
    }
}