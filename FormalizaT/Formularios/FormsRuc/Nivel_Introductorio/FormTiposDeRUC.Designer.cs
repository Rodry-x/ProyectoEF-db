namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormTiposDeRUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiposDeRUC));
            panelEscogerRenta = new Panel();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panelEscogerRenta.SuspendLayout();
            SuspendLayout();
            // 
            // panelEscogerRenta
            // 
            panelEscogerRenta.Controls.Add(button2);
            panelEscogerRenta.Controls.Add(label6);
            panelEscogerRenta.Controls.Add(label5);
            panelEscogerRenta.Controls.Add(label4);
            panelEscogerRenta.Controls.Add(label3);
            panelEscogerRenta.Controls.Add(label1);
            panelEscogerRenta.Controls.Add(label2);
            panelEscogerRenta.Controls.Add(button1);
            panelEscogerRenta.Location = new Point(6, 4);
            panelEscogerRenta.Name = "panelEscogerRenta";
            panelEscogerRenta.Size = new Size(630, 530);
            panelEscogerRenta.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(505, 469);
            button2.Name = "button2";
            button2.Size = new Size(106, 52);
            button2.TabIndex = 11;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelTiposDeRUC2_Click;
            // 
            // label6
            // 
            label6.Location = new Point(27, 315);
            label6.Name = "label6";
            label6.Size = new Size(584, 131);
            label6.TabIndex = 10;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 282);
            label5.Name = "label5";
            label5.Size = new Size(218, 23);
            label5.TabIndex = 9;
            label5.Text = "Características Principales:";
            // 
            // label4
            // 
            label4.Location = new Point(25, 184);
            label4.Name = "label4";
            label4.Size = new Size(584, 97);
            label4.TabIndex = 8;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 152);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 7;
            label3.Text = "Persona Natural";
            // 
            // label1
            // 
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(584, 76);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(589, 35);
            label2.TabIndex = 5;
            label2.Text = "Tipos de RUC: Persona natural y persona jurídica";
            // 
            // button1
            // 
            button1.Location = new Point(18, 469);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 4;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionBasica_Click;
            // 
            // FormTiposDeRUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelEscogerRenta);
            Name = "FormTiposDeRUC";
            Text = "FormTiposDeRUC";
            panelEscogerRenta.ResumeLayout(false);
            panelEscogerRenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEscogerRenta;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
    }
}