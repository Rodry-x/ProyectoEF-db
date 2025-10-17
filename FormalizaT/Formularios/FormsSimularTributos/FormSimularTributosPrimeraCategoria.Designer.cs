namespace FormalizaT.Formularios.FormsSimularTributos
{
    partial class FormSimularTributosPrimeraCategoria
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
            panelSimularTributosPrimeraCategoria = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblResultado = new Label();
            lblImpuesto = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            lblAdicional = new Label();
            panelSimularTributosPrimeraCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSimularTributosPrimeraCategoria
            // 
            panelSimularTributosPrimeraCategoria.Controls.Add(lblAdicional);
            panelSimularTributosPrimeraCategoria.Controls.Add(label6);
            panelSimularTributosPrimeraCategoria.Controls.Add(label5);
            panelSimularTributosPrimeraCategoria.Controls.Add(pictureBox1);
            panelSimularTributosPrimeraCategoria.Controls.Add(lblImpuesto);
            panelSimularTributosPrimeraCategoria.Controls.Add(lblResultado);
            panelSimularTributosPrimeraCategoria.Controls.Add(label4);
            panelSimularTributosPrimeraCategoria.Controls.Add(label3);
            panelSimularTributosPrimeraCategoria.Controls.Add(txtMonto);
            panelSimularTributosPrimeraCategoria.Controls.Add(label2);
            panelSimularTributosPrimeraCategoria.Controls.Add(button2);
            panelSimularTributosPrimeraCategoria.Controls.Add(button1);
            panelSimularTributosPrimeraCategoria.Controls.Add(label1);
            panelSimularTributosPrimeraCategoria.Location = new Point(6, 2);
            panelSimularTributosPrimeraCategoria.Name = "panelSimularTributosPrimeraCategoria";
            panelSimularTributosPrimeraCategoria.Size = new Size(630, 530);
            panelSimularTributosPrimeraCategoria.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(26, 470);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 1;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(92, 21);
            label1.Name = "label1";
            label1.Size = new Size(463, 35);
            label1.TabIndex = 0;
            label1.Text = "Simular Tributo De Primera Categoria";
            // 
            // button2
            // 
            button2.Location = new Point(416, 180);
            button2.Name = "button2";
            button2.Size = new Size(139, 42);
            button2.TabIndex = 2;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += simularImporte_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 135);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingresar el monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(225, 132);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(330, 27);
            txtMonto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 254);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 5;
            label3.Text = "Tu dinero es del:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 283);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 6;
            label4.Text = "Impuesto a pagar:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(225, 254);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(158, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "lbl_Resultado_cambiar";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(225, 283);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(154, 20);
            lblImpuesto.TabIndex = 8;
            lblImpuesto.Text = "lbl_Impuesto_cambiar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenBolsaDeAcciones;
            pictureBox1.Location = new Point(400, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 218);
            label5.Name = "label5";
            label5.Size = new Size(176, 23);
            label5.TabIndex = 10;
            label5.Text = "El impuesto es del 5%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 90);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 11;
            label6.Text = "Simular";
            // 
            // lblAdicional
            // 
            lblAdicional.Location = new Point(73, 335);
            lblAdicional.Name = "lblAdicional";
            lblAdicional.Size = new Size(306, 118);
            lblAdicional.TabIndex = 12;
            lblAdicional.Text = "lbl_Mensaje_Final";
            // 
            // FormSimularTributosPrimeraCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelSimularTributosPrimeraCategoria);
            Name = "FormSimularTributosPrimeraCategoria";
            Text = "FormSimularTributosPrimeraCategoria";
            panelSimularTributosPrimeraCategoria.ResumeLayout(false);
            panelSimularTributosPrimeraCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributosPrimeraCategoria;
        private Label label1;
        private Button button1;
        private Label lblResultado;
        private Label label4;
        private Label label3;
        private TextBox txtMonto;
        private Label label2;
        private Button button2;
        private Label lblImpuesto;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblAdicional;
    }
}