namespace FormalizaT.Formularios.FormsDeConsejos
{
    partial class FormConsejoTerceraCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsejoTerceraCategoria));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Nuevo Régimen Único Simplificado (NRUS)", resources.GetString("lstViewObligaciones.Items") }, -1);
            panelConsejoTerceraCategoria = new Panel();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstViewObligaciones = new ListView();
            panelConsejoTerceraCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panelConsejoTerceraCategoria
            // 
            panelConsejoTerceraCategoria.Controls.Add(button1);
            panelConsejoTerceraCategoria.Controls.Add(label9);
            panelConsejoTerceraCategoria.Controls.Add(label8);
            panelConsejoTerceraCategoria.Controls.Add(label7);
            panelConsejoTerceraCategoria.Controls.Add(label6);
            panelConsejoTerceraCategoria.Controls.Add(label5);
            panelConsejoTerceraCategoria.Controls.Add(label4);
            panelConsejoTerceraCategoria.Controls.Add(label3);
            panelConsejoTerceraCategoria.Controls.Add(label2);
            panelConsejoTerceraCategoria.Controls.Add(label1);
            panelConsejoTerceraCategoria.Location = new Point(7, 6);
            panelConsejoTerceraCategoria.Name = "panelConsejoTerceraCategoria";
            panelConsejoTerceraCategoria.Size = new Size(630, 530);
            panelConsejoTerceraCategoria.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(31, 470);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 9;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelConsejos_Click;
            // 
            // label9
            // 
            label9.Location = new Point(40, 409);
            label9.Name = "label9";
            label9.Size = new Size(505, 47);
            label9.TabIndex = 8;
            label9.Text = "RG: 18% mensual, 1.5% por ingresos netos y una declaración anual de 29.5% sobre utilidad neta";
            // 
            // label8
            // 
            label8.Location = new Point(40, 336);
            label8.Name = "label8";
            label8.Size = new Size(505, 67);
            label8.TabIndex = 7;
            label8.Text = "RMT: 18% mensualmente, 1% (si no superas 300UIT de ingresos netos) y declaración anual con tasas progresivas (10% hasta 15UIT de utilidad; 29.5% por el exceso)";
            // 
            // label7
            // 
            label7.Location = new Point(40, 299);
            label7.Name = "label7";
            label7.Size = new Size(515, 30);
            label7.TabIndex = 6;
            label7.Text = "RER: Tienes que pagar 18% sobre las ventas y 1.5% sobre los ingresos Netos";
            // 
            // label6
            // 
            label6.Location = new Point(40, 243);
            label6.Name = "label6";
            label6.Size = new Size(505, 47);
            label6.TabIndex = 5;
            label6.Text = "NRUS: Es el mas sencillo solo pagas de 20/s (hasta 5mil soles) o 50/s (hasta 8mil soles)";
            // 
            // label5
            // 
            label5.Location = new Point(40, 193);
            label5.Name = "label5";
            label5.Size = new Size(505, 41);
            label5.TabIndex = 4;
            label5.Text = "Cada regimen tiene diferentes obligaciones (entre mas dinero ganes, mas obligaciones )";
            // 
            // label4
            // 
            label4.Font = new Font("Sylfaen", 12F);
            label4.Location = new Point(16, 159);
            label4.Name = "label4";
            label4.Size = new Size(237, 34);
            label4.TabIndex = 3;
            label4.Text = "Obligaciones Tributarias";
            // 
            // label3
            // 
            label3.Location = new Point(40, 98);
            label3.Name = "label3";
            label3.Size = new Size(505, 41);
            label3.TabIndex = 2;
            label3.Text = "Tienes que saber identificar tu regimen, para asi no pagar demas y evitar problemas futuros";
            // 
            // label2
            // 
            label2.Font = new Font("Sylfaen", 12F);
            label2.Location = new Point(19, 64);
            label2.Name = "label2";
            label2.Size = new Size(237, 34);
            label2.TabIndex = 1;
            label2.Text = "Identifica correctamente";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 11);
            label1.Name = "label1";
            label1.Size = new Size(385, 50);
            label1.TabIndex = 0;
            label1.Text = "Renta de Tercera Categoria";
            // 
            // lstViewObligaciones
            // 
            listViewItem1.StateImageIndex = 0;
            lstViewObligaciones.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lstViewObligaciones.Location = new Point(73, 288);
            lstViewObligaciones.Name = "lstViewObligaciones";
            lstViewObligaciones.Size = new Size(427, 117);
            lstViewObligaciones.TabIndex = 5;
            lstViewObligaciones.UseCompatibleStateImageBehavior = false;
            lstViewObligaciones.View = View.Details;
            // 
            // FormConsejoTerceraCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelConsejoTerceraCategoria);
            Name = "FormConsejoTerceraCategoria";
            Text = "FormConsejoParaTerceraCategoria";
            panelConsejoTerceraCategoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ListView lstViewObligaciones;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Panel panelConsejoTerceraCategoria;
        private Button button1;
    }
}