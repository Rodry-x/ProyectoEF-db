namespace FormalizaT.Formularios
{
    partial class FormPrincipal
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
            panelPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(7, 6);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(630, 530);
            panelPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenHombrePeruanoConMegafono;
            pictureBox1.Location = new Point(88, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(594, 35);
            label1.TabIndex = 0;
            label1.Text = "Haga click en alguna de las opciones para continuar";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 541);
            Controls.Add(panelPrincipal);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label1;
        private PictureBox pictureBox1;
    }
}