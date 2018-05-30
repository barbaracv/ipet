namespace ipet
{
    partial class Registro
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
			this.dni = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.contraseña = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Correo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.registrarse2 = new System.Windows.Forms.Button();
			this.Telefono = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dni
			// 
			this.dni.Location = new System.Drawing.Point(420, 105);
			this.dni.Name = "dni";
			this.dni.Size = new System.Drawing.Size(144, 20);
			this.dni.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(363, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 24);
			this.label5.TabIndex = 28;
			this.label5.Text = "DNI";
			// 
			// contraseña
			// 
			this.contraseña.Location = new System.Drawing.Point(420, 146);
			this.contraseña.Name = "contraseña";
			this.contraseña.Size = new System.Drawing.Size(144, 20);
			this.contraseña.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(306, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 24);
			this.label4.TabIndex = 26;
			this.label4.Text = "Password";
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(126, 105);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(144, 20);
			this.Nombre.TabIndex = 25;
			this.Nombre.Text = " ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(39, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 24);
			this.label3.TabIndex = 24;
			this.label3.Text = "Nombre";
			// 
			// Correo
			// 
			this.Correo.Location = new System.Drawing.Point(126, 145);
			this.Correo.Name = "Correo";
			this.Correo.Size = new System.Drawing.Size(144, 20);
			this.Correo.TabIndex = 23;
			this.Correo.Text = " ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 24);
			this.label2.TabIndex = 22;
			this.label2.Text = "Correo";
			// 
			// registrarse2
			// 
			this.registrarse2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrarse2.Location = new System.Drawing.Point(236, 249);
			this.registrarse2.Name = "registrarse2";
			this.registrarse2.Size = new System.Drawing.Size(144, 34);
			this.registrarse2.TabIndex = 21;
			this.registrarse2.Text = "Resgistrarse";
			this.registrarse2.UseVisualStyleBackColor = true;
			this.registrarse2.Click += new System.EventHandler(this.registrarse2_Click);
			// 
			// Telefono
			// 
			this.Telefono.Location = new System.Drawing.Point(126, 183);
			this.Telefono.Name = "Telefono";
			this.Telefono.Size = new System.Drawing.Size(144, 20);
			this.Telefono.TabIndex = 20;
			this.Telefono.Text = " ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 19;
			this.label1.Text = "Telefono";
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 384);
			this.Controls.Add(this.dni);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.contraseña);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Correo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.registrarse2);
			this.Controls.Add(this.Telefono);
			this.Controls.Add(this.label1);
			this.Name = "Registro";
			this.Text = "Registro Adoptante";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrarse2;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label1;
    }
}