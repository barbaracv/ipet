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
//
//

namespace ipet
{
	public partial class Mascotas : Form
	{
		private List<DataRow> rows;


		public Mascotas()
		{
			InitializeComponent();
			LoadListViewMascotas();

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		private void LoadListViewMascotas() {


			//LEER ARCHIVO CONFIGURACION
			ConnectionStringSettings settings =
			ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			SqlCommand cmdMostrarmas = new SqlCommand("ProyectoFinal.dbo.pa_mostrarMas", conn);
			cmdMostrarmas.CommandType = CommandType.StoredProcedure;


			try
			{
				//Abrir la conexión
				conn.Open();
				//Ejecutar comando
				SqlDataReader rdr = cmdMostrarmas.ExecuteReader();
				DataTable dt = new DataTable();


				dt.Load(rdr); //Cargando una tabla donde le pasamos el DataReader
				rows = dt.AsEnumerable().ToList();

				ListView.ListViewItemCollection listam = new ListView.ListViewItemCollection(lista_mascotas);

				foreach (DataRow m in rows)
				{

					listam.Add(m["NOMBRE"].ToString(), 0);

				}

			}


			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
		private void LoadMascotaSeleccionada(DataRow n)
		{

			nombre.Text = n["NOMBRE"].ToString();
			raza.Text = n["raza"].ToString();
			sexo.Text = n["SEXO"].ToString();
			estado.Text = n["estado"].ToString();
			fechanac.Text = n["FechaNac"].ToString();
			ciudad.Text = n["CIUDAD"].ToString();
			tamaño.Text = n["tamaño"].ToString();
			foto.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, n["imagen"].ToString()));

		}
		
	

		private void LoadMascotaSeleccionadaAtributo(List<DataRow> atributos)
		{
			
			if (atributos.Count == 1)
			{
				atributo1.Text = atributos[0][0].ToString();
				valor1.Text = atributos[0][1].ToString();
			}
			if (atributos.Count == 2)
			{
				atributo1.Text = atributos[0][0].ToString();
				atributo2.Text = atributos[1][0].ToString();
				valor1.Text = atributos[0][1].ToString();
				valor2.Text = atributos[1][1].ToString();
			}

		}
		private void lista_mascotas_SelectedIndexChanged(object sender, EventArgs e)
			{
			

				if (lista_mascotas.SelectedItems.Count > 0)
				{

					DataRow n = rows.ElementAt(lista_mascotas.SelectedIndices[0]);

					LoadMascotaSeleccionada(n);
					LoadMascotaSeleccionadaAtributo(mascota.LoadAtributosxMascota(Convert.ToInt16(n["IDMascota"])));
				

				}

			}

		



		private void button2_Click(object sender, EventArgs e)
		{
			//LEER ARCHIVO CONFIGURACION
			ConnectionStringSettings settings =
				ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			SqlCommand cmdNuevoAdsp = new SqlCommand("ProyectoFinal.dbo.seleccionar_mascota", conn);
			cmdNuevoAdsp.CommandType = CommandType.StoredProcedure;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@idtipomascota", SqlDbType.Int));
			cmdNuevoAdsp.Parameters["@idtipomascota"].Value = 1;

			

			try
			{
				lista_mascotas.Clear();
				//abrir la conexion
				conn.Open();

				cmdNuevoAdsp.ExecuteNonQuery();
				SqlDataReader rdr = cmdNuevoAdsp.ExecuteReader();
				DataTable dt = new DataTable();

				dt.Load(rdr); //Cargando una tabla donde le pasamos el DataReader
				rows = dt.AsEnumerable().ToList();

				ListView.ListViewItemCollection listam = new ListView.ListViewItemCollection(lista_mascotas);

				foreach (DataRow m in rows)
				{

					listam.Add(m["NOMBRE"].ToString(), 0);

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se ha podido conectar " + ex.Message);
			}
		}

		private void gato_Click(object sender, EventArgs e)
		{
			//LEER ARCHIVO CONFIGURACION
			ConnectionStringSettings settings =
				ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			SqlCommand cmdNuevoAdsp = new SqlCommand("ProyectoFinal.dbo.seleccionar_mascota", conn);
			cmdNuevoAdsp.CommandType = CommandType.StoredProcedure;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@idtipomascota", SqlDbType.Int));
			cmdNuevoAdsp.Parameters["@idtipomascota"].Value = 2;
			


			try
			{
				lista_mascotas.Clear();
				//abrir la conexion
				conn.Open();
				
				cmdNuevoAdsp.ExecuteNonQuery();
				SqlDataReader rdr = cmdNuevoAdsp.ExecuteReader();
				DataTable dt = new DataTable();

				dt.Load(rdr); //Cargando una tabla donde le pasamos el DataReader
				rows = dt.AsEnumerable().ToList();

				ListView.ListViewItemCollection listam = new ListView.ListViewItemCollection(lista_mascotas);

				foreach (DataRow m in rows)
				{

					listam.Add(m["NOMBRE"].ToString(), 0);

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se ha podido conectar " + ex.Message);
			}
		}

		private void roedor_Click(object sender, EventArgs e)
		{
			//LEER ARCHIVO CONFIGURACION
			ConnectionStringSettings settings =
				ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			SqlCommand cmdNuevoAdsp = new SqlCommand("ProyectoFinal.dbo.seleccionar_mascota", conn);
			cmdNuevoAdsp.CommandType = CommandType.StoredProcedure;

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@idtipomascota", SqlDbType.Int));
			cmdNuevoAdsp.Parameters["@idtipomascota"].Value = 3;



			try
			{
				lista_mascotas.Clear();
				//abrir la conexion
				conn.Open();

				cmdNuevoAdsp.ExecuteNonQuery();
				SqlDataReader rdr = cmdNuevoAdsp.ExecuteReader();
				DataTable dt = new DataTable();

				dt.Load(rdr); //Cargando una tabla donde le pasamos el DataReader
				rows = dt.AsEnumerable().ToList();

				ListView.ListViewItemCollection listam = new ListView.ListViewItemCollection(lista_mascotas);

				foreach (DataRow m in rows)
				{

					listam.Add(m["NOMBRE"].ToString(), 0);

				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("No se ha podido conectar " + ex.Message);
			}
		}

		private void reservar_Click(object sender, EventArgs e)
		{
			//LEER ARCHIVO CONFIGURACION
			ConnectionStringSettings settings =
				ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			SqlCommand cmdNuevoAdsp = new SqlCommand("ProyectoFinal.dbo.pa_reservar", conn);
			cmdNuevoAdsp.CommandType = CommandType.StoredProcedure;

			DataRow n = rows.ElementAt(lista_mascotas.SelectedIndices[0]);

			cmdNuevoAdsp.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
			cmdNuevoAdsp.Parameters["@id"].Value = Convert.ToInt16(n["IDMascota"]);



			try
			{
				//abrir la conexion
				conn.Open();

				cmdNuevoAdsp.ExecuteNonQuery();
				LoadMascotaSeleccionada(n);
				LoadListViewMascotas();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se ha podido conectar " + ex.Message);

			}


		}

		private void foto_Click(object sender, EventArgs e)
		{

		}
	}
}
