namespace FormalizaT.Formularios
{
    partial class FormBeneficios
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
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeneficios));
            panelBeneficios = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panelBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(447, 285);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // panelBeneficios
            // 
            panelBeneficios.Controls.Add(pictureBox1);
            panelBeneficios.Controls.Add(label2);
            panelBeneficios.Controls.Add(label1);
            panelBeneficios.Location = new Point(6, 2);
            panelBeneficios.Margin = new Padding(3, 2, 3, 2);
            panelBeneficios.Name = "panelBeneficios";
            panelBeneficios.Size = new Size(551, 398);
            panelBeneficios.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sistemas_comprobantes_electronicos;
            pictureBox1.Location = new Point(435, 247);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(457, 51);
            label1.TabIndex = 1;
            label1.Text = "Beneficios de ser Formal";
            // 
            // FormBeneficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 404);
            Controls.Add(panelBeneficios);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBeneficios";
            Text = "FormBeneficios";
            panelBeneficios.ResumeLayout(false);
            panelBeneficios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBeneficios;
        private Label label1;
        private PictureBox pictureBox1;
    }
}