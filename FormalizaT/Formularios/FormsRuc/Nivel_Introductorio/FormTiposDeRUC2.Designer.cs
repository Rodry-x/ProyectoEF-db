namespace FormalizaT.Formularios.FormsRuc.Nivel_Introductorio
{
    partial class FormTiposDeRUC2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiposDeRUC2));
            panelTiposDeRUC2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panelTiposDeRUC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTiposDeRUC2
            // 
            panelTiposDeRUC2.Controls.Add(button1);
            panelTiposDeRUC2.Controls.Add(pictureBox1);
            panelTiposDeRUC2.Controls.Add(label5);
            panelTiposDeRUC2.Controls.Add(label4);
            panelTiposDeRUC2.Controls.Add(label2);
            panelTiposDeRUC2.Controls.Add(label1);
            panelTiposDeRUC2.Controls.Add(label3);
            panelTiposDeRUC2.Location = new Point(6, 4);
            panelTiposDeRUC2.Name = "panelTiposDeRUC2";
            panelTiposDeRUC2.Size = new Size(630, 530);
            panelTiposDeRUC2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(18, 469);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 14;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiandoAlPanelTiposDeRUC_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenDiferenciasPersonaNaturalJudicial;
            pictureBox1.Location = new Point(60, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(224, 257);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 12;
            label5.Text = "Diferencias Clave";
            // 
            // label4
            // 
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(572, 118);
            label4.TabIndex = 11;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(214, 23);
            label2.TabIndex = 10;
            label2.Text = "Características Principales";
            // 
            // label1
            // 
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(572, 72);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 14);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 8;
            label3.Text = "Persona Jurídica";
            // 
            // FormTiposDeRUC2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelTiposDeRUC2);
            Name = "FormTiposDeRUC2";
            Text = "FormTiposDeRUC2";
            panelTiposDeRUC2.ResumeLayout(false);
            panelTiposDeRUC2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTiposDeRUC2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}