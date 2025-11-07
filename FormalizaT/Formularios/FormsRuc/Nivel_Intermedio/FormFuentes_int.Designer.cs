namespace FormalizaT.Formularios.FormsRuc
{
    partial class FormFuentes_int
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
            panelFormFuentes_Int = new Panel();
            button1 = new Button();
            panelFormFuentes_Int.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormFuentes_Int
            // 
            panelFormFuentes_Int.Controls.Add(button1);
            panelFormFuentes_Int.Location = new Point(11, 13);
            panelFormFuentes_Int.Name = "panelFormFuentes_Int";
            panelFormFuentes_Int.Size = new Size(630, 530);
            panelFormFuentes_Int.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(14, 467);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 0;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelIntermedio_Click;
            // 
            // FormFuentes_int
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 555);
            Controls.Add(panelFormFuentes_Int);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFuentes_int";
            Text = "FormFuentes_int";
            panelFormFuentes_Int.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormFuentes_Int;
        private Button button1;
    }
}