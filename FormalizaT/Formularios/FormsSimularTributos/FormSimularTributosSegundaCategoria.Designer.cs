namespace FormalizaT.Formularios.FormsSimularTributos
{
    partial class FormSimularTributosSegundaCategoria
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
            panelSimularTributoSegundaCategoria = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblImpuesto = new Label();
            lblResultados = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            txtMontoNeto = new TextBox();
            txtMontoBruto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            button1 = new Button();
            label1 = new Label();
            panelSimularTributoSegundaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSimularTributoSegundaCategoria
            // 
            panelSimularTributoSegundaCategoria.Controls.Add(pictureBox2);
            panelSimularTributoSegundaCategoria.Controls.Add(pictureBox1);
            panelSimularTributoSegundaCategoria.Controls.Add(lblImpuesto);
            panelSimularTributoSegundaCategoria.Controls.Add(lblResultados);
            panelSimularTributoSegundaCategoria.Controls.Add(label7);
            panelSimularTributoSegundaCategoria.Controls.Add(label4);
            panelSimularTributoSegundaCategoria.Controls.Add(label5);
            panelSimularTributoSegundaCategoria.Controls.Add(button2);
            panelSimularTributoSegundaCategoria.Controls.Add(txtMontoNeto);
            panelSimularTributoSegundaCategoria.Controls.Add(txtMontoBruto);
            panelSimularTributoSegundaCategoria.Controls.Add(label3);
            panelSimularTributoSegundaCategoria.Controls.Add(label2);
            panelSimularTributoSegundaCategoria.Controls.Add(label6);
            panelSimularTributoSegundaCategoria.Controls.Add(button1);
            panelSimularTributoSegundaCategoria.Controls.Add(label1);
            panelSimularTributoSegundaCategoria.Location = new Point(5, 4);
            panelSimularTributoSegundaCategoria.Margin = new Padding(3, 2, 3, 2);
            panelSimularTributoSegundaCategoria.Name = "panelSimularTributoSegundaCategoria";
            panelSimularTributoSegundaCategoria.Size = new Size(551, 398);
            panelSimularTributoSegundaCategoria.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iconoHelp;
            pictureBox2.Location = new Point(300, 335);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Ayuda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenBolsaDeAcciones;
            pictureBox1.Location = new Point(355, 244);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(186, 261);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(0, 15);
            lblImpuesto.TabIndex = 23;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(186, 219);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(0, 15);
            lblResultados.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 261);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 21;
            label7.Text = "Impuesto a Pagar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 219);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 20;
            label4.Text = "Tu dinero es del:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 190);
            label5.Name = "label5";
            label5.Size = new Size(265, 19);
            label5.TabIndex = 19;
            label5.Text = "El impuesto es del 5% Bruto y 6.5% Neto";
            // 
            // button2
            // 
            button2.Location = new Point(373, 158);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(152, 26);
            button2.TabIndex = 17;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += simularImporte_Click;
            // 
            // txtMontoNeto
            // 
            txtMontoNeto.Location = new Point(226, 121);
            txtMontoNeto.Margin = new Padding(3, 2, 3, 2);
            txtMontoNeto.Name = "txtMontoNeto";
            txtMontoNeto.Size = new Size(300, 23);
            txtMontoNeto.TabIndex = 16;
            // 
            // txtMontoBruto
            // 
            txtMontoBruto.Location = new Point(226, 91);
            txtMontoBruto.Margin = new Padding(3, 2, 3, 2);
            txtMontoBruto.Name = "txtMontoBruto";
            txtMontoBruto.Size = new Size(300, 23);
            txtMontoBruto.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 122);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 14;
            label3.Text = "Ingresar el monto neto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 93);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 13;
            label2.Text = "Ingresar el monto bruto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 69);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 12;
            label6.Text = "Simular";
            // 
            // button1
            // 
            button1.Location = new Point(18, 353);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 28);
            button1.TabIndex = 2;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(73, 14);
            label1.Name = "label1";
            label1.Size = new Size(378, 28);
            label1.TabIndex = 1;
            label1.Text = "Simular Tributo De Segunda Categoria";
            // 
            // FormSimularTributosSegundaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 404);
            Controls.Add(panelSimularTributoSegundaCategoria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSimularTributosSegundaCategoria";
            Text = "FormSimularTributosSegundaCategoria";
            panelSimularTributoSegundaCategoria.ResumeLayout(false);
            panelSimularTributoSegundaCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributoSegundaCategoria;
        private Button button1;
        private Label label1;
        private Label label6;
        private Button button2;
        private TextBox txtMontoNeto;
        private TextBox txtMontoBruto;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblImpuesto;
        private Label lblResultados;
        private Label label7;
        private PictureBox pictureBox2;
    }
}