namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    partial class FormDigitalizacionDelNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDigitalizacionDelNegocio));
            panelQueEsElRuc = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panelQueEsElRuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelQueEsElRuc
            // 
            panelQueEsElRuc.AutoScroll = true;
            panelQueEsElRuc.Controls.Add(pictureBox1);
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Location = new Point(11, 15);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 928);
            panelQueEsElRuc.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagedigitalizacion;
            pictureBox1.Location = new Point(173, 735);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(3, 867);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionAvanzada_Click;
            // 
            // label1
            // 
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(598, 697);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, -3);
            label2.Name = "label2";
            label2.Size = new Size(327, 35);
            label2.TabIndex = 6;
            label2.Text = "Digitalización del Negocio";
            // 
            // FormDigitalizacionDelNegocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 948);
            Controls.Add(panelQueEsElRuc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDigitalizacionDelNegocio";
            Text = "FormDigitalizacionDelNegocio";
            panelQueEsElRuc.ResumeLayout(false);
            panelQueEsElRuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQueEsElRuc;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}