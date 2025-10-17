namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormInformacionBasica
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
            panelInformacionBasica = new Panel();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelInformacionBasica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelInformacionBasica
            // 
            panelInformacionBasica.Controls.Add(button5);
            panelInformacionBasica.Controls.Add(pictureBox5);
            panelInformacionBasica.Controls.Add(button4);
            panelInformacionBasica.Controls.Add(pictureBox4);
            panelInformacionBasica.Controls.Add(button3);
            panelInformacionBasica.Controls.Add(pictureBox3);
            panelInformacionBasica.Controls.Add(button2);
            panelInformacionBasica.Controls.Add(pictureBox2);
            panelInformacionBasica.Controls.Add(button1);
            panelInformacionBasica.Controls.Add(pictureBox1);
            panelInformacionBasica.Controls.Add(label1);
            panelInformacionBasica.Location = new Point(5, 4);
            panelInformacionBasica.Name = "panelInformacionBasica";
            panelInformacionBasica.Size = new Size(630, 530);
            panelInformacionBasica.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(366, 435);
            button5.Name = "button5";
            button5.Size = new Size(121, 54);
            button5.TabIndex = 11;
            button5.Text = "Fuentes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += cambiarAlPanelFuentes;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.imagenLibroAbierto;
            pictureBox5.Location = new Point(366, 297);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(121, 129);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(123, 435);
            button4.Name = "button4";
            button4.Size = new Size(124, 54);
            button4.TabIndex = 9;
            button4.Text = "¿Quien debe inscribirse?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += cambiarQuienDebeInscribirseEnElRuc;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.imagenPersonaPreguntandose;
            pictureBox4.Location = new Point(123, 297);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(124, 126);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(469, 224);
            button3.Name = "button3";
            button3.Size = new Size(140, 47);
            button3.TabIndex = 7;
            button3.Text = "¿Que es un RUC?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += cambiarAlPanelQueEsElRuc;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imagenSunatRegistro;
            pictureBox3.Location = new Point(469, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 129);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(228, 223);
            button2.Name = "button2";
            button2.Size = new Size(155, 48);
            button2.TabIndex = 5;
            button2.Text = "Tipos de RUC";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelTiposDeRenta;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imagenDeRuc1;
            pictureBox2.Location = new Point(228, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(21, 223);
            button1.Name = "button1";
            button1.Size = new Size(124, 48);
            button1.TabIndex = 3;
            button1.Text = "Consultar RUC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelConsultarRuc;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenConsulta;
            pictureBox1.Location = new Point(21, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(82, 5);
            label1.Name = "label1";
            label1.Size = new Size(463, 67);
            label1.TabIndex = 0;
            label1.Text = "Nivel Introduccion";
            // 
            // FormInformacionBasica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelInformacionBasica);
            Name = "FormInformacionBasica";
            Text = "FormInformacionBasica";
            panelInformacionBasica.ResumeLayout(false);
            panelInformacionBasica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformacionBasica;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private PictureBox pictureBox3;
        private Button button4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button5;
    }
}