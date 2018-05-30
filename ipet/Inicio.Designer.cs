namespace ipet
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoluntario = new System.Windows.Forms.Button();
            this.btnadoptante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvoluntario
            // 
            this.btnvoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoluntario.Location = new System.Drawing.Point(172, 151);
            this.btnvoluntario.Name = "btnvoluntario";
            this.btnvoluntario.Size = new System.Drawing.Size(146, 85);
            this.btnvoluntario.TabIndex = 0;
            this.btnvoluntario.Text = "Voluntario";
            this.btnvoluntario.UseVisualStyleBackColor = true;
            this.btnvoluntario.Click += new System.EventHandler(this.btnvoluntario_Click);
            // 
            // btnadoptante
            // 
            this.btnadoptante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadoptante.Location = new System.Drawing.Point(392, 151);
            this.btnadoptante.Name = "btnadoptante";
            this.btnadoptante.Size = new System.Drawing.Size(146, 85);
            this.btnadoptante.TabIndex = 1;
            this.btnadoptante.Text = "Adoptante";
            this.btnadoptante.UseVisualStyleBackColor = true;
            this.btnadoptante.Click += new System.EventHandler(this.btnadoptante_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 418);
            this.Controls.Add(this.btnadoptante);
            this.Controls.Add(this.btnvoluntario);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvoluntario;
        private System.Windows.Forms.Button btnadoptante;
    }
}

