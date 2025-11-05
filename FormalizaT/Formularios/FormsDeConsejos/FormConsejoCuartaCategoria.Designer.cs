namespace FormalizaT.Formularios.FormsDeConsejos
{
    partial class FormConsejoCuartaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsejoCuartaCategoria));
            panelConsejoCuartaCategoria = new Panel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            button1 = new Button();
            panelConsejoCuartaCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelConsejoCuartaCategoria
            // 
            panelConsejoCuartaCategoria.Controls.Add(linkLabel1);
            panelConsejoCuartaCategoria.Controls.Add(label6);
            panelConsejoCuartaCategoria.Controls.Add(label5);
            panelConsejoCuartaCategoria.Controls.Add(label4);
            panelConsejoCuartaCategoria.Controls.Add(label3);
            panelConsejoCuartaCategoria.Controls.Add(label2);
            panelConsejoCuartaCategoria.Controls.Add(label1);
            panelConsejoCuartaCategoria.Controls.Add(label7);
            panelConsejoCuartaCategoria.Controls.Add(button1);
            panelConsejoCuartaCategoria.Location = new Point(5, 4);
            panelConsejoCuartaCategoria.Name = "panelConsejoCuartaCategoria";
            panelConsejoCuartaCategoria.Size = new Size(630, 530);
            panelConsejoCuartaCategoria.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(224, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(55, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SUNAT";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.Location = new Point(52, 357);
            label6.Name = "label6";
            label6.Size = new Size(535, 71);
            label6.TabIndex = 17;
            label6.Text = "- Si proyectas que tus ingresos anuales no superarán el límite establecido (S/ 46,813 para 2025 o 7UIT), solicita la suspensión de retenciones a través de la plataforma en línea de la\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 321);
            label5.Name = "label5";
            label5.Size = new Size(321, 23);
            label5.TabIndex = 16;
            label5.Text = "2. Tramita la Suspensión de Retenciones";
            // 
            // label4
            // 
            label4.Location = new Point(52, 229);
            label4.Name = "label4";
            label4.Size = new Size(535, 93);
            label4.TabIndex = 15;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.Location = new Point(52, 155);
            label3.Name = "label3";
            label3.Size = new Size(535, 74);
            label3.TabIndex = 14;
            label3.Text = "- Si tus ingresos mensuales superan los S/ 3,901, debes realizar pagos a cuenta mensuales del 8% de tus ingresos, a menos que hayas tramitado la suspensión de retenciones.";
            // 
            // label2
            // 
            label2.Location = new Point(52, 101);
            label2.Name = "label2";
            label2.Size = new Size(535, 54);
            label2.TabIndex = 13;
            label2.Text = "- No estás obligado a pagar el impuesto a la renta si tus ingresos proyectados para todo el año 2025 no superan los S/ 46,813";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(290, 23);
            label1.TabIndex = 12;
            label1.Text = "1. Conoce tus Obligaciones y Límites";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(105, 11);
            label7.Name = "label7";
            label7.Size = new Size(365, 41);
            label7.TabIndex = 11;
            label7.Text = "Renta de Cuarta Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(22, 467);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 10;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelConsejos_Click;
            // 
            // FormConsejoCuartaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelConsejoCuartaCategoria);
            Name = "FormConsejoCuartaCategoria";
            Text = "FormCuartaCategoria";
            panelConsejoCuartaCategoria.ResumeLayout(false);
            panelConsejoCuartaCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsejoCuartaCategoria;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}