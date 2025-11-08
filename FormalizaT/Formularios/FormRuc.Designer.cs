namespace FormalizaT.Formularios
{
    partial class FormRuc
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
            panelRuc = new Panel();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panelRuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelRuc
            // 
            panelRuc.Controls.Add(button3);
            panelRuc.Controls.Add(pictureBox3);
            panelRuc.Controls.Add(pictureBox2);
            panelRuc.Controls.Add(button2);
            panelRuc.Controls.Add(label1);
            panelRuc.Controls.Add(pictureBox1);
            panelRuc.Controls.Add(button1);
            panelRuc.Location = new Point(4, 5);
            panelRuc.Name = "panelRuc";
            panelRuc.Size = new Size(630, 530);
            panelRuc.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(435, 363);
            button3.Name = "button3";
            button3.Size = new Size(158, 52);
            button3.TabIndex = 6;
            button3.Text = "Nivel Avanzado";
            button3.UseVisualStyleBackColor = true;
            button3.Click += cambiarAlPanelInformacionAvanzada;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imagenProfesor;
            pictureBox3.Location = new Point(435, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Adolescente;
            pictureBox2.Location = new Point(236, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(236, 363);
            button2.Name = "button2";
            button2.Size = new Size(156, 52);
            button2.TabIndex = 3;
            button2.Text = "Nivel Intermedio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelInformacionIntermedia;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(566, 67);
            label1.TabIndex = 2;
            label1.Text = "Niveles de Aprendizaje";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenNinioSaludando;
            pictureBox1.Location = new Point(27, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(27, 363);
            button1.Name = "button1";
            button1.Size = new Size(164, 52);
            button1.TabIndex = 0;
            button1.Text = "Nivel Introduccion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelInformacionBasica;
            // 
            // FormRuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 541);
            Controls.Add(panelRuc);
            Name = "FormRuc";
            Text = "FormRuc";
            panelRuc.ResumeLayout(false);
            panelRuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRuc;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox3;
        private Button button3;
    }
}