namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    partial class FormINDECOPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormINDECOPI));
            panelQueEsElRuc = new Panel();
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
            panelQueEsElRuc.AutoScroll = true;
            panelQueEsElRuc.Controls.Add(pictureBox1);
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Location = new Point(11, 5);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 1234);
            panelQueEsElRuc.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(8, 1169);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionAvanzada_Click;
            // 
            // label1
            // 
            label1.Location = new Point(8, 53);
            label1.Name = "label1";
            label1.Size = new Size(614, 833);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 9);
            label2.Name = "label2";
            label2.Size = new Size(509, 35);
            label2.TabIndex = 6;
            label2.Text = "Propiedad intelectual y registro de marca ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagePropiedadIntelectual;
            pictureBox1.Location = new Point(173, 941);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormINDECOPI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(653, 1251);
            Controls.Add(panelQueEsElRuc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormINDECOPI";
            Text = "FormINDECOPI";
            panelQueEsElRuc.ResumeLayout(false);
            panelQueEsElRuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQueEsElRuc;
        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}