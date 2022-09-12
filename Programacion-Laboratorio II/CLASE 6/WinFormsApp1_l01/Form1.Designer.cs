namespace WinFormsApp1_l01
{
    partial class Form1
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.btSaludar = new System.Windows.Forms.Button();
            this.lbTitulo_01 = new System.Windows.Forms.Label();
            this.lbTitulo_02 = new System.Windows.Forms.Label();
            this.listaMaterias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(45, 93);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(228, 23);
            this.textNombre.TabIndex = 0;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(352, 93);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(245, 23);
            this.textApellido.TabIndex = 1;
            // 
            // btSaludar
            // 
            this.btSaludar.Location = new System.Drawing.Point(352, 229);
            this.btSaludar.Name = "btSaludar";
            this.btSaludar.Size = new System.Drawing.Size(245, 38);
            this.btSaludar.TabIndex = 2;
            this.btSaludar.Text = "Saludar";
            this.btSaludar.UseVisualStyleBackColor = true;
            this.btSaludar.Click += new System.EventHandler(this.btSaludar_Click);
            // 
            // lbTitulo_01
            // 
            this.lbTitulo_01.AutoSize = true;
            this.lbTitulo_01.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo_01.Location = new System.Drawing.Point(45, 44);
            this.lbTitulo_01.Name = "lbTitulo_01";
            this.lbTitulo_01.Size = new System.Drawing.Size(78, 25);
            this.lbTitulo_01.TabIndex = 3;
            this.lbTitulo_01.Text = "Nombre";
            // 
            // lbTitulo_02
            // 
            this.lbTitulo_02.AutoSize = true;
            this.lbTitulo_02.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo_02.Location = new System.Drawing.Point(352, 44);
            this.lbTitulo_02.Name = "lbTitulo_02";
            this.lbTitulo_02.Size = new System.Drawing.Size(78, 25);
            this.lbTitulo_02.TabIndex = 4;
            this.lbTitulo_02.Text = "Apellido";
            // 
            // listaMaterias
            // 
            this.listaMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaMaterias.FormattingEnabled = true;
            this.listaMaterias.Location = new System.Drawing.Point(45, 175);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(552, 23);
            this.listaMaterias.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Materia favorita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaMaterias);
            this.Controls.Add(this.lbTitulo_02);
            this.Controls.Add(this.lbTitulo_01);
            this.Controls.Add(this.btSaludar);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola, Windows Form!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textNombre;
        private TextBox textApellido;
        private Button btSaludar;
        private Label lbTitulo_01;
        private Label lbTitulo_02;
        private ComboBox listaMaterias;
        private Label label1;
    }
}