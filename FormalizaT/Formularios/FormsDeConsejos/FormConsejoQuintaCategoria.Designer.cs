namespace FormalizaT.Formularios.FormsDeConsejos
{
    partial class FormConsejoQuintaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsejoQuintaCategoria));
            panelConsejoQuintaCategoria = new Panel();
            label7 = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelConsejoQuintaCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelConsejoQuintaCategoria
            // 
            panelConsejoQuintaCategoria.Controls.Add(label5);
            panelConsejoQuintaCategoria.Controls.Add(label4);
            panelConsejoQuintaCategoria.Controls.Add(label3);
            panelConsejoQuintaCategoria.Controls.Add(label2);
            panelConsejoQuintaCategoria.Controls.Add(label1);
            panelConsejoQuintaCategoria.Controls.Add(label7);
            panelConsejoQuintaCategoria.Controls.Add(button1);
            panelConsejoQuintaCategoria.Location = new Point(6, 7);
            panelConsejoQuintaCategoria.Name = "panelConsejoQuintaCategoria";
            panelConsejoQuintaCategoria.Size = new Size(630, 530);
            panelConsejoQuintaCategoria.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(116, 6);
            label7.Name = "label7";
            label7.Size = new Size(368, 41);
            label7.TabIndex = 12;
            label7.Text = "Renta de Quinta Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(22, 474);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 11;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelConsejos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 57);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 13;
            label1.Text = "1. Conoce el Umbral de Ingresos";
            // 
            // label2
            // 
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(535, 75);
            label2.TabIndex = 14;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 166);
            label3.Name = "label3";
            label3.Size = new Size(401, 23);
            label3.TabIndex = 15;
            label3.Text = "2. Aprovecha las Deducciones Adicionales de 3 UIT";
            // 
            // label4
            // 
            label4.Location = new Point(22, 197);
            label4.Name = "label4";
            label4.Size = new Size(583, 175);
            label4.TabIndex = 16;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.Location = new Point(25, 374);
            label5.Name = "label5";
            label5.Size = new Size(553, 73);
            label5.TabIndex = 17;
            label5.Text = resources.GetString("label5.Text");
            // 
            // FormConsejoQuintaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelConsejoQuintaCategoria);
            Name = "FormConsejoQuintaCategoria";
            Text = "FormConsejoParaQuintaCategoria";
            panelConsejoQuintaCategoria.ResumeLayout(false);
            panelConsejoQuintaCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsejoQuintaCategoria;
        private Button button1;
        private Label label7;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}