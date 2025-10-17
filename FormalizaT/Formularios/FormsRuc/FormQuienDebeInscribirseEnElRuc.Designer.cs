namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormQuienDebeInscribirseEnElRuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuienDebeInscribirseEnElRuc));
            panelQuienDebeInscribirseEnElRuc = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelQuienDebeInscribirseEnElRuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelQuienDebeInscribirseEnElRuc
            // 
            panelQuienDebeInscribirseEnElRuc.Controls.Add(button2);
            panelQuienDebeInscribirseEnElRuc.Controls.Add(button1);
            panelQuienDebeInscribirseEnElRuc.Controls.Add(label2);
            panelQuienDebeInscribirseEnElRuc.Controls.Add(pictureBox1);
            panelQuienDebeInscribirseEnElRuc.Controls.Add(label1);
            panelQuienDebeInscribirseEnElRuc.Location = new Point(6, 4);
            panelQuienDebeInscribirseEnElRuc.Name = "panelQuienDebeInscribirseEnElRuc";
            panelQuienDebeInscribirseEnElRuc.Size = new Size(630, 530);
            panelQuienDebeInscribirseEnElRuc.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(421, 466);
            button2.Name = "button2";
            button2.Size = new Size(176, 50);
            button2.TabIndex = 4;
            button2.Text = "Pasos De Inscripcion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelInscripcionRuc;
            // 
            // button1
            // 
            button1.Location = new Point(18, 469);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionBasica;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 9);
            label2.Name = "label2";
            label2.Size = new Size(418, 35);
            label2.TabIndex = 2;
            label2.Text = "¿Quién debe inscribirse en el RUC?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenAppPersonas;
            pictureBox1.Location = new Point(120, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(25, 58);
            label1.Name = "label1";
            label1.Size = new Size(572, 191);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormQuienDebeInscribirseEnElRuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelQuienDebeInscribirseEnElRuc);
            Name = "FormQuienDebeInscribirseEnElRuc";
            Text = "FormQuienDebeInscribirseEnElRuc";
            panelQuienDebeInscribirseEnElRuc.ResumeLayout(false);
            panelQuienDebeInscribirseEnElRuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQuienDebeInscribirseEnElRuc;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}