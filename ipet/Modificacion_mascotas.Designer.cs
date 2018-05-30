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
            this.lista_modificacion = new System.Windows.Forms.DataGridView();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idtipomascotaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idtipomascotaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.seleccionar_mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoFinalDataSet = new ipet.ProyectoFinalDataSet();
            this.seleccionar_mascotaTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.seleccionar_mascotaTableAdapter();
            this.tableAdapterManager = new ipet.ProyectoFinalDataSetTableAdapters.TableAdapterManager();
            this.tipo_mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_mascotaTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.Tipo_mascotaTableAdapter();
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasTableAdapter = new ipet.ProyectoFinalDataSetTableAdapters.MascotasTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.lista_modificacion)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seleccionar_mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
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
            this.lista_modificacion.Location = new System.Drawing.Point(56, 47);
            this.lista_modificacion.Name = "lista_modificacion";
            this.lista_modificacion.Size = new System.Drawing.Size(559, 345);
            this.lista_modificacion.TabIndex = 0;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idtipomascotaToolStripLabel,
            this.idtipomascotaToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(695, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idtipomascotaToolStripLabel
            // 
            this.idtipomascotaToolStripLabel.Name = "idtipomascotaToolStripLabel";
            this.idtipomascotaToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.idtipomascotaToolStripLabel.Text = "idtipomascota:";
            // 
            // idtipomascotaToolStripTextBox
            // 
            this.idtipomascotaToolStripTextBox.Name = "idtipomascotaToolStripTextBox";
            this.idtipomascotaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // seleccionar_mascotaBindingSource
            // 
            this.seleccionar_mascotaBindingSource.DataMember = "seleccionar_mascota";
            this.seleccionar_mascotaBindingSource.DataSource = this.proyectoFinalDataSet;
            // 
            // proyectoFinalDataSet
            // 
            this.proyectoFinalDataSet.DataSetName = "ProyectoFinalDataSet";
            this.proyectoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "Mascotas";
            this.mascotasBindingSource.DataSource = this.proyectoFinalDataSet;
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
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
            // Modificacion_mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.lista_modificacion);
            this.Name = "Modificacion_mascotas";
            this.Text = "Modificacion_mascotas";
            this.Load += new System.EventHandler(this.Modificacion_mascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_modificacion)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seleccionar_mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_modificacion;
        private ProyectoFinalDataSet proyectoFinalDataSet;
        private System.Windows.Forms.BindingSource seleccionar_mascotaBindingSource;
        private ProyectoFinalDataSetTableAdapters.seleccionar_mascotaTableAdapter seleccionar_mascotaTableAdapter;
        private ProyectoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idtipomascotaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idtipomascotaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
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
    }
}