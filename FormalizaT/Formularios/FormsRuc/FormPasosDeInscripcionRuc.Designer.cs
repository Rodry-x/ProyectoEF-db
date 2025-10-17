namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormPasosDeInscripcionRuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasosDeInscripcionRuc));
            panelInscripcionRuc = new Panel();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            li = new LinkLabel();
            panelInscripcionRuc.SuspendLayout();
            SuspendLayout();
            // 
            // panelInscripcionRuc
            // 
            panelInscripcionRuc.Controls.Add(li);
            panelInscripcionRuc.Controls.Add(label7);
            panelInscripcionRuc.Controls.Add(linkLabel1);
            panelInscripcionRuc.Controls.Add(label5);
            panelInscripcionRuc.Controls.Add(label6);
            panelInscripcionRuc.Controls.Add(button2);
            panelInscripcionRuc.Controls.Add(button1);
            panelInscripcionRuc.Controls.Add(label4);
            panelInscripcionRuc.Controls.Add(label3);
            panelInscripcionRuc.Controls.Add(label1);
            panelInscripcionRuc.Controls.Add(label2);
            panelInscripcionRuc.Location = new Point(5, 4);
            panelInscripcionRuc.Name = "panelInscripcionRuc";
            panelInscripcionRuc.Size = new Size(630, 530);
            panelInscripcionRuc.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(109, 315);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(338, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.youtube.com/watch?v=t-G6G3MKjao";
            linkLabel1.LinkClicked += linkVideoPasoAPasoDeInscripcionRUC_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 315);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 11;
            label5.Text = "URL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(31, 241);
            label6.Name = "label6";
            label6.Size = new Size(303, 23);
            label6.TabIndex = 10;
            label6.Text = "Procedimiento para inscripcion virtual:";
            // 
            // button2
            // 
            button2.Location = new Point(31, 466);
            button2.Name = "button2";
            button2.Size = new Size(148, 37);
            button2.TabIndex = 8;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelQuienDebeInscribirseEnElRuc;
            // 
            // button1
            // 
            button1.Location = new Point(227, 388);
            button1.Name = "button1";
            button1.Size = new Size(223, 49);
            button1.TabIndex = 7;
            button1.Text = "Diferencias entre las Rentas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelTiposDeRenta;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 360);
            label4.Name = "label4";
            label4.Size = new Size(279, 23);
            label4.TabIndex = 6;
            label4.Text = "Como saber a que RUC pertenezco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(31, 64);
            label3.Name = "label3";
            label3.Size = new Size(218, 23);
            label3.TabIndex = 5;
            label3.Text = "Requisitos y Procedimiento";
            // 
            // label1
            // 
            label1.Location = new Point(31, 101);
            label1.Name = "label1";
            label1.Size = new Size(543, 124);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 7);
            label2.Name = "label2";
            label2.Size = new Size(390, 35);
            label2.TabIndex = 3;
            label2.Text = "Pasos para inscribirte en el RUC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 277);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 13;
            label7.Text = "URL:";
            // 
            // li
            // 
            li.AutoSize = true;
            li.Location = new Point(113, 278);
            li.Name = "li";
            li.Size = new Size(454, 20);
            li.TabIndex = 14;
            li.TabStop = true;
            li.Text = "https://ww1.sunat.gob.pe/ol-ti-itadminforuc-inscripcion/inscripcion";
            li.LinkClicked += linkParaGenerarClaveSOl_LinkLabel;
            // 
            // FormPasosDeInscripcionRuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelInscripcionRuc);
            Name = "FormPasosDeInscripcionRuc";
            Text = "FormPasosDeInscripcionRuc";
            panelInscripcionRuc.ResumeLayout(false);
            panelInscripcionRuc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInscripcionRuc;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label6;
        private LinkLabel li;
        private Label label7;
    }
}