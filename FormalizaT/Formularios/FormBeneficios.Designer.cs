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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panelBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBeneficios
            // 
            panelBeneficios.Controls.Add(pictureBox1);
            panelBeneficios.Controls.Add(label2);
            panelBeneficios.Controls.Add(label1);
            panelBeneficios.Location = new Point(7, 3);
            panelBeneficios.Name = "panelBeneficios";
            panelBeneficios.Size = new Size(630, 530);
            panelBeneficios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 6);
            label1.Name = "label1";
            label1.Size = new Size(562, 62);
            label1.TabIndex = 1;
            label1.Text = "Beneficios de ser Formal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 72);
            label2.Name = "label2";
            label2.Size = new Size(566, 380);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sistemas_comprobantes_electronicos;
            pictureBox1.Location = new Point(495, 294);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormBeneficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelBeneficios);
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