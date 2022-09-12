namespace formApp_01
{
    partial class isLabelText
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
            this.idButton = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idButton
            // 
            this.idButton.Location = new System.Drawing.Point(229, 290);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(302, 137);
            this.idButton.TabIndex = 0;
            this.idButton.Text = "Mostrar";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelText.Location = new System.Drawing.Point(290, 151);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(184, 46);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Hello word";
            // 
            // isLabelText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.idButton);
            this.Name = "isLabelText";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button idButton;
        private Label labelText;
    }
}