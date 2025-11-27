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
            pictureBox1 = new PictureBox();
            lblDetalles = new Label();
            label6 = new Label();
            lblResultado = new Label();
            lblImpuesto = new Label();
            label5 = new Label();
            label4 = new Label();
            txtBonificaciones = new TextBox();
            label3 = new Label();
            txtSueldoMensual = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panelSimularTributosQuintaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSimularTributosQuintaCategoria
            // 
            panelSimularTributosQuintaCategoria.Controls.Add(pictureBox1);
            panelSimularTributosQuintaCategoria.Controls.Add(lblDetalles);
            panelSimularTributosQuintaCategoria.Controls.Add(label6);
            panelSimularTributosQuintaCategoria.Controls.Add(lblResultado);
            panelSimularTributosQuintaCategoria.Controls.Add(lblImpuesto);
            panelSimularTributosQuintaCategoria.Controls.Add(label5);
            panelSimularTributosQuintaCategoria.Controls.Add(label4);
            panelSimularTributosQuintaCategoria.Controls.Add(txtBonificaciones);
            panelSimularTributosQuintaCategoria.Controls.Add(label3);
            panelSimularTributosQuintaCategoria.Controls.Add(txtSueldoMensual);
            panelSimularTributosQuintaCategoria.Controls.Add(button2);
            panelSimularTributosQuintaCategoria.Controls.Add(label2);
            panelSimularTributosQuintaCategoria.Controls.Add(button1);
            panelSimularTributosQuintaCategoria.Controls.Add(label1);
            panelSimularTributosQuintaCategoria.Location = new Point(6, 4);
            panelSimularTributosQuintaCategoria.Name = "panelSimularTributosQuintaCategoria";
            panelSimularTributosQuintaCategoria.Size = new Size(630, 531);
            panelSimularTributosQuintaCategoria.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconoHelp;
            pictureBox1.Location = new Point(568, 479);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Ayuda_Click;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(215, 403);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(75, 20);
            lblDetalles.TabIndex = 15;
            lblDetalles.Text = "Resultado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 403);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 14;
            label6.Text = "Detalles:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(215, 261);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(215, 332);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(75, 20);
            lblImpuesto.TabIndex = 12;
            lblImpuesto.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 261);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 11;
            label5.Text = "Resultados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 332);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 10;
            label4.Text = "Impuesto a pagar:";
            // 
            // txtBonificaciones
            // 
            txtBonificaciones.Location = new Point(215, 176);
            txtBonificaciones.Margin = new Padding(3, 4, 3, 4);
            txtBonificaciones.Name = "txtBonificaciones";
            txtBonificaciones.Size = new Size(183, 27);
            txtBonificaciones.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 180);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 8;
            label3.Text = "Bonificaciones:";
            // 
            // txtSueldoMensual
            // 
            txtSueldoMensual.Location = new Point(215, 101);
            txtSueldoMensual.Margin = new Padding(3, 4, 3, 4);
            txtSueldoMensual.Name = "txtSueldoMensual";
            txtSueldoMensual.Size = new Size(183, 27);
            txtSueldoMensual.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(197, 479);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 31);
            button2.TabIndex = 6;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 105);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 5;
            label2.Text = "Sueldo Mensual:";
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
            // FormSimularTributosQuintaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 539);
            Controls.Add(panelSimularTributosQuintaCategoria);
            Name = "FormSimularTributosQuintaCategoria";
            Text = "FormSimularTributosQuintaCategoria";
            panelSimularTributosQuintaCategoria.ResumeLayout(false);
            panelSimularTributosQuintaCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributosQuintaCategoria;
        private Label label1;
        private Button button1;
        private TextBox txtBonificaciones;
        private Label label3;
        private TextBox txtSueldoMensual;
        private Button button2;
        private Label label2;
        private Label lblResultado;
        private Label lblImpuesto;
        private Label label5;
        private Label label4;
        private Label lblDetalles;
        private Label label6;
        private PictureBox pictureBox1;
    }
}