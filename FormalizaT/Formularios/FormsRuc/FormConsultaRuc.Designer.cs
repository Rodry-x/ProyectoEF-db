namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormConsultaRuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaRuc));
            panelConsultaRuc = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panelConsultaRuc.SuspendLayout();
            SuspendLayout();
            // 
            // panelConsultaRuc
            // 
            panelConsultaRuc.Controls.Add(button2);
            panelConsultaRuc.Controls.Add(button1);
            panelConsultaRuc.Controls.Add(label5);
            panelConsultaRuc.Controls.Add(label4);
            panelConsultaRuc.Controls.Add(label3);
            panelConsultaRuc.Controls.Add(label1);
            panelConsultaRuc.Controls.Add(label2);
            panelConsultaRuc.Location = new Point(7, 4);
            panelConsultaRuc.Name = "panelConsultaRuc";
            panelConsultaRuc.Size = new Size(630, 530);
            panelConsultaRuc.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(194, 5);
            label2.Name = "label2";
            label2.Size = new Size(210, 35);
            label2.TabIndex = 7;
            label2.Text = "Consulta de RUC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 8;
            label1.Text = "Estados el RUC:";
            // 
            // label3
            // 
            label3.Location = new Point(58, 80);
            label3.Name = "label3";
            label3.Size = new Size(522, 207);
            label3.TabIndex = 9;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 298);
            label4.Name = "label4";
            label4.Size = new Size(203, 23);
            label4.TabIndex = 10;
            label4.Text = "¿Como hago la consulta?";
            // 
            // label5
            // 
            label5.Location = new Point(68, 330);
            label5.Name = "label5";
            label5.Size = new Size(512, 47);
            label5.TabIndex = 11;
            label5.Text = "Es facil, solo tienes que poner el DNI de la persona que quieres consultar, o el RUC de la persona o empresa de la que quieras consultar";
            // 
            // button1
            // 
            button1.Location = new Point(243, 390);
            button1.Name = "button1";
            button1.Size = new Size(139, 39);
            button1.TabIndex = 12;
            button1.Text = "Consultar RUC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += consultarRuc;
            // 
            // button2
            // 
            button2.Location = new Point(20, 465);
            button2.Name = "button2";
            button2.Size = new Size(132, 45);
            button2.TabIndex = 13;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelInformacionBasica;
            // 
            // FormConsultaRuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelConsultaRuc);
            Name = "FormConsultaRuc";
            Text = "FormConsultaRuc";
            panelConsultaRuc.ResumeLayout(false);
            panelConsultaRuc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsultaRuc;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}