namespace ipet
{
    partial class LoginAdoptante
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
            this.label3 = new System.Windows.Forms.Label();
            this.registrarse1 = new System.Windows.Forms.Button();
            this.inicio_sesionA = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Advertencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "No estoy registrado";
            // 
            // registrarse1
            // 
            this.registrarse1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarse1.Location = new System.Drawing.Point(374, 317);
            this.registrarse1.Name = "registrarse1";
            this.registrarse1.Size = new System.Drawing.Size(144, 34);
            this.registrarse1.TabIndex = 15;
            this.registrarse1.Text = "Resgistrarse";
            this.registrarse1.UseVisualStyleBackColor = true;
            this.registrarse1.Click += new System.EventHandler(this.registrarse1_Click);
            // 
            // inicio_sesionA
            // 
            this.inicio_sesionA.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_sesionA.Location = new System.Drawing.Point(183, 239);
            this.inicio_sesionA.Name = "inicio_sesionA";
            this.inicio_sesionA.Size = new System.Drawing.Size(144, 34);
            this.inicio_sesionA.TabIndex = 14;
            this.inicio_sesionA.Text = "Iniciar sesion";
            this.inicio_sesionA.UseVisualStyleBackColor = true;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(183, 196);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(144, 20);
            this.contraseña.TabIndex = 13;
            this.contraseña.Text = " ";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(183, 151);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(144, 20);
            this.correo.TabIndex = 12;
            this.correo.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Correo";
            // 
            // Advertencia
            // 
            this.Advertencia.Location = new System.Drawing.Point(415, 215);
            this.Advertencia.Multiline = true;
            this.Advertencia.Name = "Advertencia";
            this.Advertencia.Size = new System.Drawing.Size(162, 58);
            this.Advertencia.TabIndex = 17;
            // 
            // LoginAdoptante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 387);
            this.Controls.Add(this.Advertencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registrarse1);
            this.Controls.Add(this.inicio_sesionA);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginAdoptante";
            this.Text = "LoginAdoptante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrarse1;
        private System.Windows.Forms.Button inicio_sesionA;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Advertencia;
    }
}