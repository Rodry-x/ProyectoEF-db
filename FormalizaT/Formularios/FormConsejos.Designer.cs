namespace FormalizaT.Formularios
{
    partial class FormConsejos
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
            panelConsejos = new Panel();
            iconRucQuintaCategoria = new PictureBox();
            iconRucCuartaCategoria = new PictureBox();
            iconRucTerceraCategoria = new PictureBox();
            iconRucSegundaCategoria = new PictureBox();
            iconRucPrimeraCategoria = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnTipsSegundaCat = new Button();
            btnTipsPrimeraCat = new Button();
            label1 = new Label();
            panelConsejos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRucQuintaCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRucCuartaCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRucTerceraCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRucSegundaCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRucPrimeraCategoria).BeginInit();
            SuspendLayout();
            // 
            // panelConsejos
            // 
            panelConsejos.Controls.Add(iconRucQuintaCategoria);
            panelConsejos.Controls.Add(iconRucCuartaCategoria);
            panelConsejos.Controls.Add(iconRucTerceraCategoria);
            panelConsejos.Controls.Add(iconRucSegundaCategoria);
            panelConsejos.Controls.Add(iconRucPrimeraCategoria);
            panelConsejos.Controls.Add(button3);
            panelConsejos.Controls.Add(button2);
            panelConsejos.Controls.Add(button1);
            panelConsejos.Controls.Add(btnTipsSegundaCat);
            panelConsejos.Controls.Add(btnTipsPrimeraCat);
            panelConsejos.Controls.Add(label1);
            panelConsejos.Location = new Point(5, 2);
            panelConsejos.Name = "panelConsejos";
            panelConsejos.Size = new Size(630, 530);
            panelConsejos.TabIndex = 0;
            // 
            // iconRucQuintaCategoria
            // 
            iconRucQuintaCategoria.Image = Properties.Resources.imagenDeTrabajadorOficina;
            iconRucQuintaCategoria.Location = new Point(352, 276);
            iconRucQuintaCategoria.Name = "iconRucQuintaCategoria";
            iconRucQuintaCategoria.Size = new Size(160, 159);
            iconRucQuintaCategoria.SizeMode = PictureBoxSizeMode.Zoom;
            iconRucQuintaCategoria.TabIndex = 10;
            iconRucQuintaCategoria.TabStop = false;
            // 
            // iconRucCuartaCategoria
            // 
            iconRucCuartaCategoria.Image = Properties.Resources.imagenDeTrabajadorEnConstruccion;
            iconRucCuartaCategoria.Location = new Point(97, 276);
            iconRucCuartaCategoria.Name = "iconRucCuartaCategoria";
            iconRucCuartaCategoria.Size = new Size(160, 159);
            iconRucCuartaCategoria.SizeMode = PictureBoxSizeMode.Zoom;
            iconRucCuartaCategoria.TabIndex = 9;
            iconRucCuartaCategoria.TabStop = false;
            // 
            // iconRucTerceraCategoria
            // 
            iconRucTerceraCategoria.Image = Properties.Resources.imagenEmpresa;
            iconRucTerceraCategoria.Location = new Point(440, 60);
            iconRucTerceraCategoria.Name = "iconRucTerceraCategoria";
            iconRucTerceraCategoria.Size = new Size(160, 140);
            iconRucTerceraCategoria.SizeMode = PictureBoxSizeMode.Zoom;
            iconRucTerceraCategoria.TabIndex = 8;
            iconRucTerceraCategoria.TabStop = false;
            // 
            // iconRucSegundaCategoria
            // 
            iconRucSegundaCategoria.Image = Properties.Resources.imagenBolsaDeAcciones;
            iconRucSegundaCategoria.Location = new Point(232, 60);
            iconRucSegundaCategoria.Name = "iconRucSegundaCategoria";
            iconRucSegundaCategoria.Size = new Size(160, 140);
            iconRucSegundaCategoria.SizeMode = PictureBoxSizeMode.Zoom;
            iconRucSegundaCategoria.TabIndex = 7;
            iconRucSegundaCategoria.TabStop = false;
            // 
            // iconRucPrimeraCategoria
            // 
            iconRucPrimeraCategoria.Image = Properties.Resources.imagenDeAlquilarCasa;
            iconRucPrimeraCategoria.Location = new Point(28, 60);
            iconRucPrimeraCategoria.Name = "iconRucPrimeraCategoria";
            iconRucPrimeraCategoria.Size = new Size(160, 140);
            iconRucPrimeraCategoria.SizeMode = PictureBoxSizeMode.Zoom;
            iconRucPrimeraCategoria.TabIndex = 6;
            iconRucPrimeraCategoria.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(352, 439);
            button3.Name = "button3";
            button3.Size = new Size(160, 50);
            button3.TabIndex = 5;
            button3.Text = "Tips para Ruc de Quinta Categoria";
            button3.UseVisualStyleBackColor = true;
            button3.Click += cambiarAlPanelTipsQuintaCategoria_Click;
            // 
            // button2
            // 
            button2.Location = new Point(97, 437);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 4;
            button2.Text = "Tips para Ruc de Cuarta Categoria";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelTipsCuartaCategoria_Click;
            // 
            // button1
            // 
            button1.Location = new Point(440, 206);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 3;
            button1.Text = "Tips para Ruc de Tercera Categoria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelTipsTerceraCategoria_Click;
            // 
            // btnTipsSegundaCat
            // 
            btnTipsSegundaCat.Location = new Point(232, 206);
            btnTipsSegundaCat.Name = "btnTipsSegundaCat";
            btnTipsSegundaCat.Size = new Size(160, 50);
            btnTipsSegundaCat.TabIndex = 2;
            btnTipsSegundaCat.Text = "Tips para Ruc de Segunda Categoria";
            btnTipsSegundaCat.UseVisualStyleBackColor = true;
            btnTipsSegundaCat.Click += cambiarAlPanelTipsSegundaCategoria_Click;
            // 
            // btnTipsPrimeraCat
            // 
            btnTipsPrimeraCat.Location = new Point(28, 206);
            btnTipsPrimeraCat.Name = "btnTipsPrimeraCat";
            btnTipsPrimeraCat.Size = new Size(160, 50);
            btnTipsPrimeraCat.TabIndex = 1;
            btnTipsPrimeraCat.Text = "Tips para Ruc de Primera Categoria";
            btnTipsPrimeraCat.UseVisualStyleBackColor = true;
            btnTipsPrimeraCat.Click += cambiarAlPanelTipsPrimeraCategoria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(199, 6);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 0;
            label1.Text = "Algunos tips para ti";
            // 
            // FormConsejos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 539);
            Controls.Add(panelConsejos);
            Name = "FormConsejos";
            Text = "FormConsejos";
            panelConsejos.ResumeLayout(false);
            panelConsejos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconRucQuintaCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRucCuartaCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRucTerceraCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRucSegundaCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRucPrimeraCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsejos;
        private Label label1;
        private Button btnTipsPrimeraCat;
        private Button btnTipsSegundaCat;
        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox iconRucQuintaCategoria;
        private PictureBox iconRucCuartaCategoria;
        private PictureBox iconRucTerceraCategoria;
        private PictureBox iconRucSegundaCategoria;
        private PictureBox iconRucPrimeraCategoria;
    }
}