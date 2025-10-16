namespace FormalizaT
{
    partial class FormContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenedor = new Panel();
            iconoPerfil = new PictureBox();
            btnSimularTributos = new Button();
            btnAyuda = new Button();
            btnRuc = new Button();
            btnBeneficios = new Button();
            iconoTributos = new PictureBox();
            iconoConsejos = new PictureBox();
            iconoRuc = new PictureBox();
            iconoBeneficio = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)iconoPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoTributos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoConsejos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoRuc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoBeneficio).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(242, 9);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(630, 530);
            panelContenedor.TabIndex = 0;
            // 
            // iconoPerfil
            // 
            iconoPerfil.Image = Properties.Resources.iconoCiudadanos;
            iconoPerfil.Location = new Point(22, 29);
            iconoPerfil.Name = "iconoPerfil";
            iconoPerfil.Size = new Size(204, 185);
            iconoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            iconoPerfil.TabIndex = 1;
            iconoPerfil.TabStop = false;
            // 
            // btnSimularTributos
            // 
            btnSimularTributos.Location = new Point(74, 235);
            btnSimularTributos.Name = "btnSimularTributos";
            btnSimularTributos.Size = new Size(152, 39);
            btnSimularTributos.TabIndex = 2;
            btnSimularTributos.Text = "Simular Tributos";
            btnSimularTributos.UseVisualStyleBackColor = true;
            btnSimularTributos.Click += cambiarAlPanelSimularTributos_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(74, 289);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(152, 40);
            btnAyuda.TabIndex = 3;
            btnAyuda.Text = "Consejos";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += cambiarAlPanelConsejos_Click;
            // 
            // btnRuc
            // 
            btnRuc.Location = new Point(74, 344);
            btnRuc.Name = "btnRuc";
            btnRuc.Size = new Size(152, 40);
            btnRuc.TabIndex = 4;
            btnRuc.Text = "Tipos de Ruc";
            btnRuc.UseVisualStyleBackColor = true;
            btnRuc.Click += cambiarAlPanelRuc_Click;
            // 
            // btnBeneficios
            // 
            btnBeneficios.Location = new Point(74, 400);
            btnBeneficios.Name = "btnBeneficios";
            btnBeneficios.Size = new Size(152, 34);
            btnBeneficios.TabIndex = 5;
            btnBeneficios.Text = "Beneficios";
            btnBeneficios.UseVisualStyleBackColor = true;
            btnBeneficios.Click += cambiarAlPanelBeneficios_Click;
            // 
            // iconoTributos
            // 
            iconoTributos.Image = Properties.Resources.imagenCanchitoDeFinanzas;
            iconoTributos.Location = new Point(22, 235);
            iconoTributos.Name = "iconoTributos";
            iconoTributos.Size = new Size(46, 39);
            iconoTributos.SizeMode = PictureBoxSizeMode.Zoom;
            iconoTributos.TabIndex = 6;
            iconoTributos.TabStop = false;
            // 
            // iconoConsejos
            // 
            iconoConsejos.Image = Properties.Resources.imagenTips;
            iconoConsejos.Location = new Point(22, 289);
            iconoConsejos.Name = "iconoConsejos";
            iconoConsejos.Size = new Size(46, 40);
            iconoConsejos.SizeMode = PictureBoxSizeMode.Zoom;
            iconoConsejos.TabIndex = 7;
            iconoConsejos.TabStop = false;
            // 
            // iconoRuc
            // 
            iconoRuc.Image = Properties.Resources.imagenDeRuc;
            iconoRuc.Location = new Point(22, 344);
            iconoRuc.Name = "iconoRuc";
            iconoRuc.Size = new Size(46, 40);
            iconoRuc.SizeMode = PictureBoxSizeMode.Zoom;
            iconoRuc.TabIndex = 8;
            iconoRuc.TabStop = false;
            // 
            // iconoBeneficio
            // 
            iconoBeneficio.Image = Properties.Resources.imagenBeneficio;
            iconoBeneficio.Location = new Point(22, 400);
            iconoBeneficio.Name = "iconoBeneficio";
            iconoBeneficio.Size = new Size(46, 34);
            iconoBeneficio.SizeMode = PictureBoxSizeMode.Zoom;
            iconoBeneficio.TabIndex = 9;
            iconoBeneficio.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15F);
            btnSalir.Location = new Point(22, 481);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(204, 49);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += cerrarAplicacion_click;
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(882, 553);
            Controls.Add(btnSalir);
            Controls.Add(iconoBeneficio);
            Controls.Add(iconoRuc);
            Controls.Add(iconoConsejos);
            Controls.Add(iconoTributos);
            Controls.Add(btnBeneficios);
            Controls.Add(btnRuc);
            Controls.Add(btnAyuda);
            Controls.Add(btnSimularTributos);
            Controls.Add(iconoPerfil);
            Controls.Add(panelContenedor);
            Name = "FormContenedor";
            Text = "Formaliza-T";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)iconoPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoTributos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoConsejos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoRuc).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoBeneficio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private PictureBox iconoPerfil;
        private Button btnSimularTributos;
        private Button btnAyuda;
        private Button btnRuc;
        private Button btnBeneficios;
        private PictureBox iconoTributos;
        private PictureBox iconoConsejos;
        private PictureBox iconoRuc;
        private PictureBox iconoBeneficio;
        private Button btnSalir;
    }
}
