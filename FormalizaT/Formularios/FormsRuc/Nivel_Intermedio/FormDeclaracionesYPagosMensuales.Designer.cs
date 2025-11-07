namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    partial class FormDeclaracionesYPagosMensuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeclaracionesYPagosMensuales));
            panelQueEsElRuc = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panelQueEsElRuc.SuspendLayout();
            SuspendLayout();
            // 
            // panelQueEsElRuc
            // 
            panelQueEsElRuc.Controls.Add(button2);
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Location = new Point(11, 12);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 531);
            panelQueEsElRuc.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(471, 475);
            button2.Name = "button2";
            button2.Size = new Size(129, 45);
            button2.TabIndex = 38;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelDeclaracion2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 468);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelIntermedio_Click;
            // 
            // label1
            // 
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(598, 381);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 14);
            label2.Name = "label2";
            label2.Size = new Size(408, 35);
            label2.TabIndex = 6;
            label2.Text = "Declaraciones y pagos mensuales";
            // 
            // FormDeclaracionesYPagosMensuales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 555);
            Controls.Add(panelQueEsElRuc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDeclaracionesYPagosMensuales";
            Text = "FormDeclaracionesYPagosMensuales";
            panelQueEsElRuc.ResumeLayout(false);
            panelQueEsElRuc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQueEsElRuc;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}