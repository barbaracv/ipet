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
    public partial class LoginAdoptante : Form
    {
		
        public LoginAdoptante()
        {
            InitializeComponent();

        }

        private void registrarse1_Click(object sender, EventArgs e)
        {
            Form reg = new Registro();
            reg.Show();
        }

		private void inicio_sesionA_Click(object sender, EventArgs e)
		{
			//Leer archivo configuracion
			ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];// Leer la coneection
																													   //Conectarme con bbdd
			SqlConnection conn = new SqlConnection(setting.ConnectionString);//Lee pasamos lo que hemos preparado
			string query = "SELECT ProyectoFinal.dbo.fn_comprobar_correo_contra('" + correo.Text + "','" + contraseña.Text + "')";
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
					Mascotas frm = new Mascotas();
					frm.Show();
					this.Hide();

				}
				else
				{
					Advertencia.Text=("El correo o la contraseña no son correctos");
				}

				rdr.Close();
				
			}


			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}

		}
	}
	}

