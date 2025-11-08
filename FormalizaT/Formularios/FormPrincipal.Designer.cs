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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelPrincipal = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(7, 6);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(630, 530);
            panelPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(43, 54);
            label2.Name = "label2";
            label2.Size = new Size(541, 85);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenHombrePeruanoConMegafono;
            pictureBox1.Location = new Point(126, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 377);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 1);
            label1.Name = "label1";
            label1.Size = new Size(427, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a Formaliza-T";
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
        private Label label2;
    }
}