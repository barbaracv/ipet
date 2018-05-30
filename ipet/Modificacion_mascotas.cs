using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipet
{
    public partial class Modificacion_mascotas : Form
    {
        public Modificacion_mascotas()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.seleccionar_mascotaTableAdapter.Fill(this.proyectoFinalDataSet.seleccionar_mascota, new System.Nullable<int>(((int)(System.Convert.ChangeType(idtipomascotaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Modificacion_mascotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoFinalDataSet.Mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.Fill(this.proyectoFinalDataSet.Mascotas);
            // TODO: esta línea de código carga datos en la tabla 'proyectoFinalDataSet.Tipo_mascota' Puede moverla o quitarla según sea necesario.
            this.tipo_mascotaTableAdapter.Fill(this.proyectoFinalDataSet.Tipo_mascota);

        }
    }
}
