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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVoluntario));
			this.inicio_sesionV = new System.Windows.Forms.Button();
			this.contraseñaV = new System.Windows.Forms.TextBox();
			this.Codigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorvol = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// inicio_sesionV
			// 
			this.inicio_sesionV.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inicio_sesionV.Location = new System.Drawing.Point(161, 276);
			this.inicio_sesionV.Name = "inicio_sesionV";
			this.inicio_sesionV.Size = new System.Drawing.Size(144, 34);
			this.inicio_sesionV.TabIndex = 15;
			this.inicio_sesionV.Text = "Iniciar sesion";
			this.inicio_sesionV.UseVisualStyleBackColor = true;
			this.inicio_sesionV.Click += new System.EventHandler(this.inicio_sesionV_Click);
			// 
			// contraseñaV
			// 
			this.contraseñaV.Location = new System.Drawing.Point(161, 235);
			this.contraseñaV.Name = "contraseñaV";
			this.contraseñaV.Size = new System.Drawing.Size(144, 20);
			this.contraseñaV.TabIndex = 14;
			this.contraseñaV.Text = " ";
			// 
			// Codigo
			// 
			this.Codigo.Location = new System.Drawing.Point(161, 190);
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(144, 20);
			this.Codigo.TabIndex = 13;
			this.Codigo.Text = " ";
			this.Codigo.TextChanged += new System.EventHandler(this.Codigo_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "PASSWORD";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(70, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 22);
			this.label1.TabIndex = 11;
			this.label1.Text = "CÓDIGO";
			// 
			// errorvol
			// 
			this.errorvol.Location = new System.Drawing.Point(373, 264);
			this.errorvol.Multiline = true;
			this.errorvol.Name = "errorvol";
			this.errorvol.Size = new System.Drawing.Size(171, 75);
			this.errorvol.TabIndex = 16;
			this.errorvol.TextChanged += new System.EventHandler(this.errorvol_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(25, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(297, 24);
			this.label3.TabIndex = 17;
			this.label3.Text = "GRACIAS POR COLABORAR";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(360, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 163);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(25, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 22);
			this.label4.TabIndex = 19;
			this.label4.Text = "TE NECESITAN!";
			// 
			// LoginVoluntario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(151)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(587, 376);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.errorvol);
			this.Controls.Add(this.inicio_sesionV);
			this.Controls.Add(this.contraseñaV);
			this.Controls.Add(this.Codigo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginVoluntario";
			this.Text = "LoginVoluntario";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inicio_sesionV;
        private System.Windows.Forms.TextBox contraseñaV;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox errorvol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
	}
}