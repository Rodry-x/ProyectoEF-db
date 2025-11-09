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
            lblResultados = new Label();
            lblImpuesto = new Label();
            label5 = new Label();
            cmbRegimenes = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            button2 = new Button();
            txtMontoNeto = new TextBox();
            txtMontoBruto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panelSimularTributosTerceraCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelSimularTributosTerceraCategoria
            // 
            panelSimularTributosTerceraCategoria.Controls.Add(lblResultados);
            panelSimularTributosTerceraCategoria.Controls.Add(lblImpuesto);
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
            panelSimularTributosTerceraCategoria.Location = new Point(6, 4);
            panelSimularTributosTerceraCategoria.Margin = new Padding(3, 2, 3, 2);
            panelSimularTributosTerceraCategoria.Name = "panelSimularTributosTerceraCategoria";
            panelSimularTributosTerceraCategoria.Size = new Size(551, 398);
            panelSimularTributosTerceraCategoria.TabIndex = 0;
            // 
            // lblResultados
            // 
            lblResultados.Location = new Point(60, 257);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(452, 21);
            lblResultados.TabIndex = 28;
            lblResultados.Text = "lbl_Mensaje_Resultado";
            lblResultados.Click += label7_Click;
            // 
            // lblImpuesto
            // 
            lblImpuesto.Location = new Point(61, 299);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(452, 23);
            lblImpuesto.TabIndex = 27;
            lblImpuesto.Text = "lbl_Mensaje_Impuesto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 184);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 26;
            label5.Text = "Regimen en el que estas:";
            // 
            // cmbRegimenes
            // 
            cmbRegimenes.FormattingEnabled = true;
            cmbRegimenes.Location = new Point(227, 182);
            cmbRegimenes.Margin = new Padding(3, 2, 3, 2);
            cmbRegimenes.Name = "cmbRegimenes";
            cmbRegimenes.Size = new Size(140, 23);
            cmbRegimenes.TabIndex = 25;
            cmbRegimenes.SelectedIndexChanged += cmbRegimenes_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 62);
            label4.Name = "label4";
            label4.Size = new Size(369, 15);
            label4.TabIndex = 24;
            label4.Text = "El impuesto se cobra despues de restar las ganancias con la inversion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 90);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 23;
            label6.Text = "Simular";
            // 
            // button2
            // 
            button2.Location = new Point(364, 216);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(149, 26);
            button2.TabIndex = 22;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += simularImporte_Click;
            // 
            // txtMontoNeto
            // 
            txtMontoNeto.Location = new Point(227, 145);
            txtMontoNeto.Margin = new Padding(3, 2, 3, 2);
            txtMontoNeto.Name = "txtMontoNeto";
            txtMontoNeto.Size = new Size(287, 23);
            txtMontoNeto.TabIndex = 21;
            txtMontoNeto.TextChanged += txtMontoNeto_TextChanged;
            // 
            // txtMontoBruto
            // 
            txtMontoBruto.Location = new Point(227, 115);
            txtMontoBruto.Margin = new Padding(3, 2, 3, 2);
            txtMontoBruto.Name = "txtMontoBruto";
            txtMontoBruto.Size = new Size(287, 23);
            txtMontoBruto.TabIndex = 20;
            txtMontoBruto.TextChanged += txtMontoBruto_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 146);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 19;
            label3.Text = "Ingresar el monto gastado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 116);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 18;
            label2.Text = "Ingresar el monto ganado:";
            // 
            // button1
            // 
            button1.Location = new Point(23, 356);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(68, 10);
            label1.Name = "label1";
            label1.Size = new Size(366, 28);
            label1.TabIndex = 2;
            label1.Text = "Simular Tributo De Tercera Categoria";
            // 
            // FormSimularTributosTerceraCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 404);
            Controls.Add(panelSimularTributosTerceraCategoria);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblImpuesto;
        private Label label5;
        private ComboBox cmbRegimenes;
        private Label label4;
        private Label lblResultados;
    }
}