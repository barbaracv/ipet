using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ipet
{
    public partial class LoginVoluntario : Form
    {
        public LoginVoluntario()
        {
            InitializeComponent();
        }

        private void inicio_sesionV_Click(object sender, EventArgs e)
        {
			this.Hide();
			//Leer archivo configuracion
			ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];// Leer la coneection
																													   //Conectarme con bbdd
			SqlConnection conn = new SqlConnection(setting.ConnectionString);//Lee pasamos lo que hemos preparado
			string query = "SELECT ProyectoFinal.dbo.fn_comprobar_usuario_contraseña(" + Codigo.Text + "," + contraseñaV.Text + ")";
			SqlCommand cmdVerCO = new SqlCommand(query, conn); //Ver el campo de operacion

			try
			{
				//Abrir la conexión
				conn.Open();
				//Ejecutar comando
				SqlDataReader rdr = cmdVerCO.ExecuteReader();
				rdr.Read();

				if (rdr.GetValue(0).ToString() == "SI")
				{
					Modificacion_mascotas frm = new Modificacion_mascotas();
					frm.Show();
				}
				else
				{
					MessageBox.Show("El usuario o la contraseña no son correctos");
				}

				rdr.Close();
			}


			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}

		}

        private void Codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
