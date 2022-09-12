namespace WinFormsApp1_l01
{
    partial class Form2
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
            this.lbTitulo_01 = new System.Windows.Forms.Label();
            this.lbTitulo_02 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo_01
            // 
            this.lbTitulo_01.AutoSize = true;
            this.lbTitulo_01.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo_01.Location = new System.Drawing.Point(27, 36);
            this.lbTitulo_01.Name = "lbTitulo_01";
            this.lbTitulo_01.Size = new System.Drawing.Size(452, 45);
            this.lbTitulo_01.TabIndex = 0;
            this.lbTitulo_01.Text = "Hola, desde Windows Forms!!!";
            // 
            // lbTitulo_02
            // 
            this.lbTitulo_02.AutoSize = true;
            this.lbTitulo_02.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo_02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitulo_02.Location = new System.Drawing.Point(27, 133);
            this.lbTitulo_02.Name = "lbTitulo_02";
            this.lbTitulo_02.Size = new System.Drawing.Size(46, 28);
            this.lbTitulo_02.TabIndex = 1;
            this.lbTitulo_02.Text = "Text";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 228);
            this.Controls.Add(this.lbTitulo_02);
            this.Controls.Add(this.lbTitulo_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludos!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitulo_01;
        private Label lbTitulo_02;
    }
}