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
            SuspendLayout();
            // 
            // panelRuc
            // 
            panelRuc.Location = new Point(4, 5);
            panelRuc.Name = "panelRuc";
            panelRuc.Size = new Size(630, 530);
            panelRuc.TabIndex = 0;
            // 
            // FormRuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 541);
            Controls.Add(panelRuc);
            Name = "FormRuc";
            Text = "FormRuc";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRuc;
    }
}