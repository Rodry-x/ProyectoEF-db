namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    partial class FormEmisiónComprobantesElectrónicos2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmisiónComprobantesElectrónicos2));
            panelQueEsElRuc = new Panel();
            linkLabel1 = new LinkLabel();
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
            panelQueEsElRuc.Controls.Add(linkLabel1);
            panelQueEsElRuc.Controls.Add(pictureBox1);
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Location = new Point(11, 12);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 531);
            panelQueEsElRuc.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(18, 93);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(184, 20);
            linkLabel1.TabIndex = 41;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.sunat.gob.pe/";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(443, 358);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(29, 468);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelComprobante1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(598, 322);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 10);
            label2.Name = "label2";
            label2.Size = new Size(465, 35);
            label2.TabIndex = 6;
            label2.Text = "Emisión de Comprobantes Electrónicos";
            // 
            // FormEmisiónComprobantesElectrónicos2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 555);
            Controls.Add(panelQueEsElRuc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEmisiónComprobantesElectrónicos2";
            Text = "FormEmisiónComprobantesElectrónicos2";
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
        private LinkLabel linkLabel1;
    }
}