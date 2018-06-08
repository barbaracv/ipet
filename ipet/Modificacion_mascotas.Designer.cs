namespace ipet
{
    partial class Modificacion_mascotas
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificacion_mascotas));
			this.lista_modificacion = new System.Windows.Forms.DataGridView();
			this.iDMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoMascotaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sEXODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tamañoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.razaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proyectoFinalDataSet = new ipet.ProyectoFinalDataSet();
			this.seleccionar_mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.seleccionar_mascotaTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.seleccionar_mascotaTableAdapter();
			this.tableAdapterManager = new ipet.ProyectoFinalDataSetTableAdapters.TableAdapterManager();
			this.tipo_mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tipo_mascotaTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.Tipo_mascotaTableAdapter();
			this.mascotasTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.MascotasTableAdapter();
			this.atributosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.atributosTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.AtributosTableAdapter();
			this.atributosDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.lista_modificacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.seleccionar_mascotaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipo_mascotaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.atributosDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lista_modificacion
			// 
			this.lista_modificacion.AutoGenerateColumns = false;
			this.lista_modificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lista_modificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMascotaDataGridViewTextBoxColumn,
            this.tipoMascotaIDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.sEXODataGridViewTextBoxColumn,
            this.tamañoDataGridViewTextBoxColumn,
            this.razaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.imagenDataGridViewTextBoxColumn});
			this.lista_modificacion.DataSource = this.mascotasBindingSource;
			this.lista_modificacion.Location = new System.Drawing.Point(12, 38);
			this.lista_modificacion.Name = "lista_modificacion";
			this.lista_modificacion.RowHeadersWidth = 5;
			this.lista_modificacion.Size = new System.Drawing.Size(1004, 125);
			this.lista_modificacion.TabIndex = 0;
			// 
			// iDMascotaDataGridViewTextBoxColumn
			// 
			this.iDMascotaDataGridViewTextBoxColumn.DataPropertyName = "IDMascota";
			this.iDMascotaDataGridViewTextBoxColumn.HeaderText = "IDMascota";
			this.iDMascotaDataGridViewTextBoxColumn.Name = "iDMascotaDataGridViewTextBoxColumn";
			this.iDMascotaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tipoMascotaIDDataGridViewTextBoxColumn
			// 
			this.tipoMascotaIDDataGridViewTextBoxColumn.DataPropertyName = "TipoMascota_ID";
			this.tipoMascotaIDDataGridViewTextBoxColumn.HeaderText = "TipoMascota_ID";
			this.tipoMascotaIDDataGridViewTextBoxColumn.Name = "tipoMascotaIDDataGridViewTextBoxColumn";
			// 
			// nOMBREDataGridViewTextBoxColumn
			// 
			this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
			this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
			this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
			// 
			// fechaNacDataGridViewTextBoxColumn
			// 
			this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac";
			this.fechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac";
			this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
			// 
			// cIUDADDataGridViewTextBoxColumn
			// 
			this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
			this.cIUDADDataGridViewTextBoxColumn.HeaderText = "CIUDAD";
			this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
			// 
			// sEXODataGridViewTextBoxColumn
			// 
			this.sEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO";
			this.sEXODataGridViewTextBoxColumn.HeaderText = "SEXO";
			this.sEXODataGridViewTextBoxColumn.Name = "sEXODataGridViewTextBoxColumn";
			// 
			// tamañoDataGridViewTextBoxColumn
			// 
			this.tamañoDataGridViewTextBoxColumn.DataPropertyName = "Tamaño";
			this.tamañoDataGridViewTextBoxColumn.HeaderText = "Tamaño";
			this.tamañoDataGridViewTextBoxColumn.Name = "tamañoDataGridViewTextBoxColumn";
			// 
			// razaDataGridViewTextBoxColumn
			// 
			this.razaDataGridViewTextBoxColumn.DataPropertyName = "Raza";
			this.razaDataGridViewTextBoxColumn.HeaderText = "Raza";
			this.razaDataGridViewTextBoxColumn.Name = "razaDataGridViewTextBoxColumn";
			// 
			// estadoDataGridViewTextBoxColumn
			// 
			this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
			this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
			this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
			// 
			// imagenDataGridViewTextBoxColumn
			// 
			this.imagenDataGridViewTextBoxColumn.DataPropertyName = "imagen";
			this.imagenDataGridViewTextBoxColumn.HeaderText = "imagen";
			this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
			// 
			// mascotasBindingSource
			// 
			this.mascotasBindingSource.DataMember = "Mascotas";
			this.mascotasBindingSource.DataSource = this.proyectoFinalDataSet;
			// 
			// proyectoFinalDataSet
			// 
			this.proyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet";
			this.proyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// seleccionar_mascotaBindingSource
			// 
			this.seleccionar_mascotaBindingSource.DataMember = "seleccionar_mascota";
			this.seleccionar_mascotaBindingSource.DataSource = this.proyectoFinalDataSet;
			// 
			// seleccionar_mascotaTableAdapter
			// 
			this.seleccionar_mascotaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AdoptanteTableAdapter = null;
			this.tableAdapterManager.AtributosTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.MascotasTableAdapter = null;
			this.tableAdapterManager.Tipo_mascotaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ipet.ProyectoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.VoluntarioTableAdapter = null;
			// 
			// tipo_mascotaBindingSource
			// 
			this.tipo_mascotaBindingSource.DataMember = "Tipo_mascota";
			this.tipo_mascotaBindingSource.DataSource = this.proyectoFinalDataSet;
			// 
			// tipo_mascotaTableAdapter
			// 
			this.tipo_mascotaTableAdapter.ClearBeforeFill = true;
			// 
			// mascotasTableAdapter
			// 
			this.mascotasTableAdapter.ClearBeforeFill = true;
			// 
			// atributosBindingSource
			// 
			this.atributosBindingSource.DataMember = "Atributos";
			this.atributosBindingSource.DataSource = this.proyectoFinalDataSet;
			// 
			// atributosTableAdapter
			// 
			this.atributosTableAdapter.ClearBeforeFill = true;
			// 
			// atributosDataGridView
			// 
			this.atributosDataGridView.AutoGenerateColumns = false;
			this.atributosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.atributosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.atributosDataGridView.DataSource = this.atributosBindingSource;
			this.atributosDataGridView.Location = new System.Drawing.Point(12, 186);
			this.atributosDataGridView.Name = "atributosDataGridView";
			this.atributosDataGridView.Size = new System.Drawing.Size(442, 244);
			this.atributosDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "IDAtributo";
			this.dataGridViewTextBoxColumn1.HeaderText = "IDAtributo";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "IDMascota";
			this.dataGridViewTextBoxColumn2.HeaderText = "IDMascota";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Atributo";
			this.dataGridViewTextBoxColumn3.HeaderText = "Atributo";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
			this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(633, 185);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 163);
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(12, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 23);
			this.label7.TabIndex = 32;
			this.label7.Text = "Datos :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(506, 351);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(478, 31);
			this.label1.TabIndex = 33;
			this.label1.Text = "Desde 2007 ayudando a que las";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(506, 385);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(478, 31);
			this.label2.TabIndex = 34;
			this.label2.Text = "mascotas encuentren su hogar!";
			// 
			// Modificacion_mascotas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(151)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(1024, 441);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.atributosDataGridView);
			this.Controls.Add(this.lista_modificacion);
			this.Name = "Modificacion_mascotas";
			this.Text = "Modificacion_mascotas";
			this.Load += new System.EventHandler(this.Modificacion_mascotas_Load);
			((System.ComponentModel.ISupportInitialize)(this.lista_modificacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.seleccionar_mascotaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipo_mascotaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.atributosDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_modificacion;
        private ProyectoFinalDataSet proyectoFinalDataSet;
        private System.Windows.Forms.BindingSource seleccionar_mascotaBindingSource;
        private ProyectoFinalDataSetTableAdapters.seleccionar_mascotaTableAdapter seleccionar_mascotaTableAdapter;
        private ProyectoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tipo_mascotaBindingSource;
        private ProyectoFinalDataSetTableAdapters.Tipo_mascotaTableAdapter tipo_mascotaTableAdapter;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private ProyectoFinalDataSetTableAdapters.MascotasTableAdapter mascotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMascotaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource atributosBindingSource;
		private ProyectoFinalDataSetTableAdapters.AtributosTableAdapter atributosTableAdapter;
		private System.Windows.Forms.DataGridView atributosDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}