namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormQueEsElRuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueEsElRuc));
            panelQueEsElRuc = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelQueEsElRuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelQueEsElRuc
            // 
            panelQueEsElRuc.Controls.Add(button2);
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Controls.Add(pictureBox1);
            panelQueEsElRuc.Location = new Point(12, 12);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 530);
            panelQueEsElRuc.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(455, 469);
            button2.Name = "button2";
            button2.Size = new Size(160, 52);
            button2.TabIndex = 8;
            button2.Text = "¿Para que nos sirve?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelParaQueNosSirve;
            // 
            // button1
            // 
            button1.Location = new Point(29, 468);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionBasica;
            // 
            // label1
            // 
            label1.Location = new Point(38, 54);
            label1.Name = "label1";
            label1.Size = new Size(572, 230);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 7);
            label2.Name = "label2";
            label2.Size = new Size(193, 35);
            label2.TabIndex = 6;
            label2.Text = "¿Qué es el Ruc?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenSunatRuc;
            pictureBox1.Location = new Point(147, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormQueEsElRuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 554);
            Controls.Add(panelQueEsElRuc);
            Name = "FormQueEsElRuc";
            Text = "FormQueEsElRuc";
            panelQueEsElRuc.ResumeLayout(false);
            panelQueEsElRuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQueEsElRuc;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
    }
}