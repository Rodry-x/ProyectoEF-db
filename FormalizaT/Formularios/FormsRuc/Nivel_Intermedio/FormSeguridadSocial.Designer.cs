namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    partial class FormSeguridadSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguridadSocial));
            panelQueEsElRuc = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panelQueEsElRuc.SuspendLayout();
            SuspendLayout();
            // 
            // panelQueEsElRuc
            // 
            panelQueEsElRuc.AutoScroll = true;
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Location = new Point(11, 12);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 815);
            panelQueEsElRuc.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(18, 753);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelIntermedio_Click;
            // 
            // label1
            // 
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(598, 697);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 0);
            label2.Name = "label2";
            label2.Size = new Size(475, 35);
            label2.TabIndex = 6;
            label2.Text = "Seguridad Social: ESSALUD y Pensiones\r\n";
            // 
            // FormSeguridadSocial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 832);
            Controls.Add(panelQueEsElRuc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSeguridadSocial";
            Text = "FormSeguridadSocial";
            panelQueEsElRuc.ResumeLayout(false);
            panelQueEsElRuc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQueEsElRuc;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}