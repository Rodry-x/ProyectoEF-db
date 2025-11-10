namespace FormalizaT.Formularios.FormsRuc.Nivel_Avanzado
{
    partial class FormCumplimientoLegalIntegral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCumplimientoLegalIntegral));
            panelQueEsElRuc = new Panel();
            label3 = new Label();
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
            panelQueEsElRuc.Controls.Add(label3);
            panelQueEsElRuc.Controls.Add(pictureBox1);
            panelQueEsElRuc.Controls.Add(button1);
            panelQueEsElRuc.Controls.Add(label1);
            panelQueEsElRuc.Controls.Add(label2);
            panelQueEsElRuc.Location = new Point(11, 15);
            panelQueEsElRuc.Name = "panelQueEsElRuc";
            panelQueEsElRuc.Size = new Size(630, 915);
            panelQueEsElRuc.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(16, 671);
            label3.Name = "label3";
            label3.Size = new Size(238, 158);
            label3.TabIndex = 40;
            label3.Text = "Otras Normas Relevantes\r\n\r\n• Seguridad y salud ocupacional.\r\n• Protección y defensa civiles.\r\n• La adecuada documentación y cumplimientos laborales asociados.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenCumplimiento;
            pictureBox1.Location = new Point(270, 666);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(3, 860);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionAvanzada_Click;
            // 
            // label1
            // 
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(598, 609);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 4);
            label2.Name = "label2";
            label2.Size = new Size(353, 35);
            label2.TabIndex = 6;
            label2.Text = "Cumplimiento Legal Integral";
            // 
            // FormCumplimientoLegalIntegral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 935);
            Controls.Add(panelQueEsElRuc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCumplimientoLegalIntegral";
            Text = "FormCumplimientoLegalIntegral";
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
        private Label label3;
    }
}