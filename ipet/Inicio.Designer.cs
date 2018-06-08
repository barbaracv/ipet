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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
			this.btnvoluntario = new System.Windows.Forms.Button();
			this.btnadoptante = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnvoluntario
			// 
			this.btnvoluntario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(28)))));
			this.btnvoluntario.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnvoluntario.Location = new System.Drawing.Point(169, 253);
			this.btnvoluntario.Name = "btnvoluntario";
			this.btnvoluntario.Size = new System.Drawing.Size(146, 85);
			this.btnvoluntario.TabIndex = 0;
			this.btnvoluntario.Text = "VOLUNTARIO";
			this.btnvoluntario.UseVisualStyleBackColor = false;
			this.btnvoluntario.Click += new System.EventHandler(this.btnvoluntario_Click);
			// 
			// btnadoptante
			// 
			this.btnadoptante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(28)))));
			this.btnadoptante.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnadoptante.Location = new System.Drawing.Point(373, 253);
			this.btnadoptante.Name = "btnadoptante";
			this.btnadoptante.Size = new System.Drawing.Size(146, 85);
			this.btnadoptante.TabIndex = 1;
			this.btnadoptante.Text = "ADOPTANTE";
			this.btnadoptante.UseVisualStyleBackColor = false;
			this.btnadoptante.Click += new System.EventHandler(this.btnadoptante_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(254, 55);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 163);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(151)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(704, 418);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnadoptante);
			this.Controls.Add(this.btnvoluntario);
			this.Name = "Inicio";
			this.Text = "Inicio";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvoluntario;
        private System.Windows.Forms.Button btnadoptante;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

