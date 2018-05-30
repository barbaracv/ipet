namespace ipet
{
    partial class LoginVoluntario
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
            this.inicio_sesionV = new System.Windows.Forms.Button();
            this.contraseñaV = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inicio_sesionV
            // 
            this.inicio_sesionV.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_sesionV.Location = new System.Drawing.Point(272, 229);
            this.inicio_sesionV.Name = "inicio_sesionV";
            this.inicio_sesionV.Size = new System.Drawing.Size(144, 34);
            this.inicio_sesionV.TabIndex = 15;
            this.inicio_sesionV.Text = "Iniciar sesion";
            this.inicio_sesionV.UseVisualStyleBackColor = true;
            this.inicio_sesionV.Click += new System.EventHandler(this.inicio_sesionV_Click);
            // 
            // contraseñaV
            // 
            this.contraseñaV.Location = new System.Drawing.Point(272, 162);
            this.contraseñaV.Name = "contraseñaV";
            this.contraseñaV.Size = new System.Drawing.Size(144, 20);
            this.contraseñaV.TabIndex = 14;
            this.contraseñaV.Text = " ";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(272, 117);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(144, 20);
            this.Codigo.TabIndex = 13;
            this.Codigo.Text = " ";
            this.Codigo.TextChanged += new System.EventHandler(this.Codigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo";
            // 
            // LoginVoluntario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 376);
            this.Controls.Add(this.inicio_sesionV);
            this.Controls.Add(this.contraseñaV);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginVoluntario";
            this.Text = "LoginVoluntario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inicio_sesionV;
        private System.Windows.Forms.TextBox contraseñaV;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}