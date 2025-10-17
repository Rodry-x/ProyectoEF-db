namespace FormalizaT.Formularios
{
    partial class FormConsejoPrimeraCategoria
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
            panelConsejoPrimeraCategoria = new Panel();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            panelConsejoPrimeraCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelConsejoPrimeraCategoria
            // 
            panelConsejoPrimeraCategoria.Controls.Add(label8);
            panelConsejoPrimeraCategoria.Controls.Add(label7);
            panelConsejoPrimeraCategoria.Controls.Add(button1);
            panelConsejoPrimeraCategoria.Controls.Add(label6);
            panelConsejoPrimeraCategoria.Controls.Add(linkLabel1);
            panelConsejoPrimeraCategoria.Controls.Add(label5);
            panelConsejoPrimeraCategoria.Controls.Add(label4);
            panelConsejoPrimeraCategoria.Controls.Add(label3);
            panelConsejoPrimeraCategoria.Controls.Add(label2);
            panelConsejoPrimeraCategoria.Controls.Add(label1);
            panelConsejoPrimeraCategoria.Location = new Point(6, 5);
            panelConsejoPrimeraCategoria.Name = "panelConsejoPrimeraCategoria";
            panelConsejoPrimeraCategoria.Size = new Size(630, 530);
            panelConsejoPrimeraCategoria.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 339);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 6;
            label6.Text = "URL:";
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(106, 338);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(458, 48);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.gob.pe/23767-devolucion-de-impuestos-para-rentas-de-capital-primera-y-segunda-categoria";
            linkLabel1.LinkClicked += linkPaginaDelGobiernoDevolucionDeImpuesto_LinkClicked;
            // 
            // label5
            // 
            label5.Location = new Point(64, 286);
            label5.Name = "label5";
            label5.Size = new Size(500, 48);
            label5.TabIndex = 4;
            label5.Text = "Los pagos mensuales a cuenta se restan del impuesto anual total, y si hay un saldo a favor, se pueden solicitar la devolución";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F);
            label4.Location = new Point(17, 252);
            label4.Name = "label4";
            label4.Size = new Size(144, 26);
            label4.TabIndex = 3;
            label4.Text = "Compensación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 112);
            label3.Name = "label3";
            label3.Size = new Size(432, 20);
            label3.TabIndex = 2;
            label3.Text = "El pago mensual es del 5% del monto total del alquiler pactado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F);
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(228, 26);
            label2.TabIndex = 1;
            label2.Text = "Conocer el pago mensual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(121, 13);
            label1.Name = "label1";
            label1.Size = new Size(380, 41);
            label1.TabIndex = 0;
            label1.Text = "Renta de Primera Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(17, 464);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelConsejos;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 12F);
            label7.Location = new Point(17, 152);
            label7.Name = "label7";
            label7.Size = new Size(142, 26);
            label7.TabIndex = 8;
            label7.Text = "Formalización:";
            // 
            // label8
            // 
            label8.Location = new Point(64, 190);
            label8.Name = "label8";
            label8.Size = new Size(483, 45);
            label8.TabIndex = 9;
            label8.Text = "Siempre es importante contar con un contrato de arrendamiento escrito y emitir los pagos correspondiente";
            // 
            // FormConsejoPrimeraCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelConsejoPrimeraCategoria);
            Name = "FormConsejoPrimeraCategoria";
            Text = "FormConsejoParaPrimeraCategoria";
            panelConsejoPrimeraCategoria.ResumeLayout(false);
            panelConsejoPrimeraCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsejoPrimeraCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label8;
        private Label label7;
    }
}