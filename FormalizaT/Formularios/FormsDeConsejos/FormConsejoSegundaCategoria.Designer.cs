namespace FormalizaT.Formularios.FormsDeConsejos
{
    partial class FormConsejoSegundaCategoria
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
            panelConsejoSegundaCategoria = new Panel();
            label6 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            linkLabel2 = new LinkLabel();
            panelConsejoSegundaCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelConsejoSegundaCategoria
            // 
            panelConsejoSegundaCategoria.Controls.Add(linkLabel2);
            panelConsejoSegundaCategoria.Controls.Add(label8);
            panelConsejoSegundaCategoria.Controls.Add(label1);
            panelConsejoSegundaCategoria.Controls.Add(label7);
            panelConsejoSegundaCategoria.Controls.Add(label6);
            panelConsejoSegundaCategoria.Controls.Add(label5);
            panelConsejoSegundaCategoria.Controls.Add(linkLabel1);
            panelConsejoSegundaCategoria.Controls.Add(label3);
            panelConsejoSegundaCategoria.Controls.Add(label2);
            panelConsejoSegundaCategoria.Controls.Add(label4);
            panelConsejoSegundaCategoria.Controls.Add(button1);
            panelConsejoSegundaCategoria.Location = new Point(5, 5);
            panelConsejoSegundaCategoria.Name = "panelConsejoSegundaCategoria";
            panelConsejoSegundaCategoria.Size = new Size(630, 530);
            panelConsejoSegundaCategoria.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(73, 198);
            label6.Name = "label6";
            label6.Size = new Size(512, 68);
            label6.TabIndex = 9;
            label6.Text = "No todas las operaciones están afectas, ejemplo:  Si el inmueble es la casa del vendedor, si el inmueble es vendido por un precio menor o igual al monto pagado para su adquisición (no hay ganancia)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 267);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "URL:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(117, 267);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(486, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://personas.sunat.gob.pe/vendo-mi-casa/rentas-segunda-categoria";
            linkLabel1.LinkClicked += linkPaginaRentaSegundaCategoriaExecciones_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F);
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(209, 26);
            label3.TabIndex = 6;
            label3.Text = "Conoce las excepciones";
            // 
            // label2
            // 
            label2.Location = new Point(73, 101);
            label2.Name = "label2";
            label2.Size = new Size(502, 49);
            label2.TabIndex = 5;
            label2.Text = "Abarca los ingresos por venta de inmuebles, valores mobiliarios (acciones, fondo mutuos), dividendos, intereses por préstamos y regalías.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F);
            label4.Location = new Point(31, 72);
            label4.Name = "label4";
            label4.Size = new Size(226, 26);
            label4.TabIndex = 4;
            label4.Text = "Identifica correctamente";
            // 
            // button1
            // 
            button1.Location = new Point(31, 470);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 2;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelConsejos;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(117, 16);
            label7.Name = "label7";
            label7.Size = new Size(396, 41);
            label7.TabIndex = 1;
            label7.Text = "Renta de Segunda Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F);
            label1.Location = new Point(31, 306);
            label1.Name = "label1";
            label1.Size = new Size(280, 26);
            label1.TabIndex = 10;
            label1.Text = "Conoce tu cronograma de pago";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 346);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 11;
            label8.Text = "PDF:";
            // 
            // linkLabel2
            // 
            linkLabel2.Location = new Point(113, 346);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(486, 45);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://cdn.www.gob.pe/uploads/document/file/4014659/3817927-cronograma_2025.pdf?v=1736202698";
            linkLabel2.LinkClicked += linkPDF_LinkClicked;
            // 
            // FormConsejoSegundaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelConsejoSegundaCategoria);
            Name = "FormConsejoSegundaCategoria";
            Text = "FormConsejoParaSegundaCategoria";
            panelConsejoSegundaCategoria.ResumeLayout(false);
            panelConsejoSegundaCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsejoSegundaCategoria;
        private Button button1;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label7;
        private Label label1;
        private LinkLabel linkLabel2;
        private Label label8;
    }
}