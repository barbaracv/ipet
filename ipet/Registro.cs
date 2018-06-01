using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ipet
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

		private void registrarse2_Click(object sender, EventArgs e)
		{
			//LEER ARCHIVO CONFIGURACION
			ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			SqlCommand cmdNuevoAdsp = new SqlCommand("ProyectoFinal.dbo.pa_insAdopt", conn);
			cmdNuevoAdsp.CommandType = CommandType.StoredProcedure;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 10));
			cmdNuevoAdsp.Parameters["@nombre"].Value = Nombre.Text;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 80));
			cmdNuevoAdsp.Parameters["@correo"].Value = Correo.Text;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@telfn", SqlDbType.NVarChar, 10));
			cmdNuevoAdsp.Parameters["@telfn"].Value = Telefono.Text;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@dni", SqlDbType.NVarChar, 10));
			cmdNuevoAdsp.Parameters["@dni"].Value = dni.Text;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.NVarChar, 12));
			cmdNuevoAdsp.Parameters["@contrasena"].Value = contraseña.Text;

			Form ma = new Mascotas();
			ma.Show();


			try
			{
				
				conn.Open();

				cmdNuevoAdsp.ExecuteNonQuery();

				Form mar = new Mascotas();
				mar.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se ha podido conectar " + ex.Message);
			}
		}
	}
}
