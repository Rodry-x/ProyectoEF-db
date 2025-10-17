namespace FormalizaT.Formularios.FormsSimularTributos
{
    partial class FormSimularTributosTerceraCategoria
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
            panelSimularTributosTerceraCategoria = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            txtMontoNeto = new TextBox();
            txtMontoBruto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            cmbRegimenes = new ComboBox();
            label5 = new Label();
            lblResultado = new Label();
            panelSimularTributosTerceraCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelSimularTributosTerceraCategoria
            // 
            panelSimularTributosTerceraCategoria.Controls.Add(lblResultado);
            panelSimularTributosTerceraCategoria.Controls.Add(label5);
            panelSimularTributosTerceraCategoria.Controls.Add(cmbRegimenes);
            panelSimularTributosTerceraCategoria.Controls.Add(label4);
            panelSimularTributosTerceraCategoria.Controls.Add(label6);
            panelSimularTributosTerceraCategoria.Controls.Add(button2);
            panelSimularTributosTerceraCategoria.Controls.Add(txtMontoNeto);
            panelSimularTributosTerceraCategoria.Controls.Add(txtMontoBruto);
            panelSimularTributosTerceraCategoria.Controls.Add(label3);
            panelSimularTributosTerceraCategoria.Controls.Add(label2);
            panelSimularTributosTerceraCategoria.Controls.Add(button1);
            panelSimularTributosTerceraCategoria.Controls.Add(label1);
            panelSimularTributosTerceraCategoria.Location = new Point(7, 5);
            panelSimularTributosTerceraCategoria.Name = "panelSimularTributosTerceraCategoria";
            panelSimularTributosTerceraCategoria.Size = new Size(630, 530);
            panelSimularTributosTerceraCategoria.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(26, 474);
            button1.Name = "button1";
            button1.Size = new Size(107, 42);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(78, 14);
            label1.Name = "label1";
            label1.Size = new Size(456, 35);
            label1.TabIndex = 2;
            label1.Text = "Simular Tributo De Tercera Categoria";
            // 
            // button2
            // 
            button2.Location = new Point(416, 288);
            button2.Name = "button2";
            button2.Size = new Size(170, 35);
            button2.TabIndex = 22;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += simularImporte_Click;
            // 
            // txtMontoNeto
            // 
            txtMontoNeto.Location = new Point(259, 193);
            txtMontoNeto.Name = "txtMontoNeto";
            txtMontoNeto.Size = new Size(327, 27);
            txtMontoNeto.TabIndex = 21;
            // 
            // txtMontoBruto
            // 
            txtMontoBruto.Location = new Point(259, 153);
            txtMontoBruto.Name = "txtMontoBruto";
            txtMontoBruto.Size = new Size(327, 27);
            txtMontoBruto.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 195);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 19;
            label3.Text = "Ingresar el monto gastado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 155);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 18;
            label2.Text = "Ingresar el monto ganado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 120);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 23;
            label6.Text = "Simular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 82);
            label4.Name = "label4";
            label4.Size = new Size(466, 20);
            label4.TabIndex = 24;
            label4.Text = "El impuesto se cobra despues de restar las ganancias con la inversion";
            // 
            // cmbRegimenes
            // 
            cmbRegimenes.FormattingEnabled = true;
            cmbRegimenes.Location = new Point(259, 242);
            cmbRegimenes.Name = "cmbRegimenes";
            cmbRegimenes.Size = new Size(159, 28);
            cmbRegimenes.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 245);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 26;
            label5.Text = "Regimen en el que estas:";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(69, 353);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(517, 102);
            lblResultado.TabIndex = 27;
            lblResultado.Text = "lbl_Mensaje_Resultado";
            // 
            // FormSimularTributosTerceraCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelSimularTributosTerceraCategoria);
            Name = "FormSimularTributosTerceraCategoria";
            Text = "FormSimularTributosTerceraCategoria";
            panelSimularTributosTerceraCategoria.ResumeLayout(false);
            panelSimularTributosTerceraCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSimularTributosTerceraCategoria;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox txtMontoNeto;
        private TextBox txtMontoBruto;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label lblResultado;
        private Label label5;
        private ComboBox cmbRegimenes;
        private Label label4;
    }
}