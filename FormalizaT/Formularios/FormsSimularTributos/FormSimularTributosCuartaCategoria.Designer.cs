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
            SuspendLayout();
            // 
            // panelSimularTributosCuartaCategoria
            // 
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
            panelSimularTributosCuartaCategoria.Location = new Point(5, 4);
            panelSimularTributosCuartaCategoria.Name = "panelSimularTributosCuartaCategoria";
            panelSimularTributosCuartaCategoria.Size = new Size(630, 530);
            panelSimularTributosCuartaCategoria.TabIndex = 0;
            // 
            // lblImpuesto
            // 
            lblImpuesto.Location = new Point(286, 368);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(301, 63);
            lblImpuesto.TabIndex = 32;
            lblImpuesto.Text = "lbl__cambiar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 368);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 31;
            label5.Text = "impuesto a Pagar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 286);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 30;
            label4.Text = "Resultados:";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(286, 286);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(301, 56);
            lblResultado.TabIndex = 29;
            lblResultado.Text = "lbl__cambiar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 235);
            label3.Name = "label3";
            label3.Size = new Size(366, 23);
            label3.TabIndex = 28;
            label3.Text = "El impuesto a pagar depende de cuanto ganas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 93);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 27;
            label6.Text = "Simular";
            // 
            // button1
            // 
            button1.Location = new Point(22, 469);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelSimularTributos;
            // 
            // button2
            // 
            button2.Location = new Point(417, 171);
            button2.Name = "button2";
            button2.Size = new Size(170, 35);
            button2.TabIndex = 26;
            button2.Text = "Simular Importe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += simularImporte;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(80, 19);
            label1.Name = "label1";
            label1.Size = new Size(448, 35);
            label1.TabIndex = 2;
            label1.Text = "Simular Tributo De Cuarta Categoria";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(260, 126);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(327, 27);
            txtMonto.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 128);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 24;
            label2.Text = "Ingresar el monto ganado:";
            // 
            // FormSimularTributosCuartaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelSimularTributosCuartaCategoria);
            Name = "FormSimularTributosCuartaCategoria";
            Text = "FormSimularTributosCuartaCategoria";
            panelSimularTributosCuartaCategoria.ResumeLayout(false);
            panelSimularTributosCuartaCategoria.PerformLayout();
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
    }
}