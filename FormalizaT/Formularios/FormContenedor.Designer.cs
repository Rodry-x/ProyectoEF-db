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
            components = new System.ComponentModel.Container();
            panelContenedor = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            sidebar = new FlowLayoutPanel();
            materialButton6 = new MaterialSkin.Controls.MaterialButton();
            pcbMenu = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelMenu = new Panel();
            label1 = new Label();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(50, 61);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(630, 530);
            panelContenedor.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = Properties.Resources.iconoCerdo;
            materialButton1.Location = new Point(5, 8);
            materialButton1.Margin = new Padding(5, 8, 5, 8);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(182, 48);
            materialButton1.TabIndex = 13;
            materialButton1.Text = "Tributos           ";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += cambiarAlPanelSimularTributos_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = Properties.Resources.iconBook;
            materialButton2.Location = new Point(5, 72);
            materialButton2.Margin = new Padding(5, 8, 5, 8);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(181, 48);
            materialButton2.TabIndex = 14;
            materialButton2.Text = "Aprendizaje      ";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += cambiarAlPanelRuc_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = Properties.Resources.iconoBeneficio;
            materialButton3.Location = new Point(5, 136);
            materialButton3.Margin = new Padding(5, 8, 5, 8);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(181, 48);
            materialButton3.TabIndex = 15;
            materialButton3.Text = "Beneficios           ";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += cambiarAlPanelBeneficios_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = Properties.Resources.iconTips;
            materialButton4.Location = new Point(5, 200);
            materialButton4.Margin = new Padding(5, 8, 5, 8);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(182, 48);
            materialButton4.TabIndex = 16;
            materialButton4.Text = "Consejos";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += cambiarAlPanelConsejos_Click;
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = Properties.Resources.iconPapel;
            materialButton5.Location = new Point(5, 264);
            materialButton5.Margin = new Padding(5, 8, 5, 8);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(181, 48);
            materialButton5.TabIndex = 17;
            materialButton5.Text = "Encuesta";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += enviarAlFormularioDeGoogle_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(129, 201, 250);
            sidebar.Controls.Add(materialButton1);
            sidebar.Controls.Add(materialButton2);
            sidebar.Controls.Add(materialButton3);
            sidebar.Controls.Add(materialButton4);
            sidebar.Controls.Add(materialButton5);
            sidebar.Controls.Add(materialButton6);
            sidebar.Location = new Point(0, 59);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(50, 537);
            sidebar.TabIndex = 18;
            // 
            // materialButton6
            // 
            materialButton6.AutoSize = false;
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = Properties.Resources.iconExit1;
            materialButton6.Location = new Point(4, 326);
            materialButton6.Margin = new Padding(4, 6, 4, 6);
            materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(181, 48);
            materialButton6.TabIndex = 21;
            materialButton6.Text = "Salir";
            materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = true;
            materialButton6.Click += cerrarAplicacion_click;
            // 
            // pcbMenu
            // 
            pcbMenu.Image = Properties.Resources.iconMenu;
            pcbMenu.Location = new Point(11, 3);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(29, 31);
            pcbMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMenu.TabIndex = 20;
            pcbMenu.TabStop = false;
            pcbMenu.Click += menu_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(129, 201, 250);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(pcbMenu);
            panelMenu.Location = new Point(1, 24);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(687, 37);
            panelMenu.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(54, 3);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 21;
            label1.Text = "Formaliza-T";
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(680, 592);
            Controls.Add(panelMenu);
            Controls.Add(sidebar);
            Controls.Add(panelContenedor);
            FormStyle = FormStyles.ActionBar_None;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormContenedor";
            Padding = new Padding(3, 24, 3, 3);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Formaliza-T";
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private FlowLayoutPanel sidebar;
        private PictureBox pcbMenu;
        private System.Windows.Forms.Timer sidebarTransition;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private Panel panelMenu;
        private Label label1;
    }
}
