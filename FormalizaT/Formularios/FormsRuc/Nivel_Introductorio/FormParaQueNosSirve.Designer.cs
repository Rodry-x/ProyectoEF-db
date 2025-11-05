namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormParaQueNosSirve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParaQueNosSirve));
            panelParaQueNosSirve = new Panel();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panelParaQueNosSirve.SuspendLayout();
            SuspendLayout();
            // 
            // panelParaQueNosSirve
            // 
            panelParaQueNosSirve.Controls.Add(button1);
            panelParaQueNosSirve.Controls.Add(label3);
            panelParaQueNosSirve.Controls.Add(label1);
            panelParaQueNosSirve.Controls.Add(label2);
            panelParaQueNosSirve.Location = new Point(5, 4);
            panelParaQueNosSirve.Name = "panelParaQueNosSirve";
            panelParaQueNosSirve.Size = new Size(630, 530);
            panelParaQueNosSirve.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(23, 459);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 6;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelQueEsElRuc;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 56);
            label3.Name = "label3";
            label3.Size = new Size(427, 28);
            label3.TabIndex = 5;
            label3.Text = "Algunas de las funciones y utilidades del RUC";
            // 
            // label1
            // 
            label1.Location = new Point(24, 105);
            label1.Name = "label1";
            label1.Size = new Size(591, 278);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 6);
            label2.Name = "label2";
            label2.Size = new Size(205, 35);
            label2.TabIndex = 3;
            label2.Text = "¿Para qué sirve?";
            // 
            // FormParaQueNosSirve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 538);
            Controls.Add(panelParaQueNosSirve);
            Name = "FormParaQueNosSirve";
            Text = "FormParaQueNosSirve";
            panelParaQueNosSirve.ResumeLayout(false);
            panelParaQueNosSirve.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelParaQueNosSirve;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}