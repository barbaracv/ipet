﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ipet
{
	class mascota
	{
		public string nombre;
		public DateTime fechanac;
		public string ciudad;
		public string sexo;
		public string tamano;
		public string raza;
		public string estado;
		public string imagen;

		public mascota(string nombre, DateTime fechanac, string ciudad, string sexo, string tamano,
			string raza, string estado, string imagen)
		{
			this.nombre = nombre;
			this.fechanac = fechanac;
			this.ciudad = ciudad;
			this.sexo = sexo;
			this.tamano = tamano;
			this.raza = raza;
			this.estado = estado;
			this.imagen = imagen;
		}


		public mascota(string nombre, DateTime fechanac, string sexo, string tamano,
			string estado)
		{
			this.nombre = nombre;
			this.fechanac = fechanac;
			this.sexo = sexo;
			this.tamano = tamano;
			this.estado = estado;

		}
		

		/// <summary>
		/// Este método nos permite crear un DataReader con los atributos y valores de cada mascota pasándole su ID.
		/// </summary>
		public static List<DataRow> LoadAtributosxMascota(int idmasc)
		{
			List<DataRow> atributos = null;
			ConnectionStringSettings settings =
			ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
			//conectar con bbd
			SqlConnection conn = new SqlConnection(settings.ConnectionString);
			string query = "SELECT Atributo, Valor from Atributos where IDMascota="+idmasc;
			SqlCommand cmdVerAtri = new SqlCommand(query, conn);
			SqlDataReader rdr;

			try
			{
				//Abrir la conexión
				conn.Open();
				//Ejecutar comando
				rdr = cmdVerAtri.ExecuteReader();
				DataTable dt = new DataTable();

				dt.Load(rdr); //Cargando una tabla donde le pasamos el DataReader
				atributos = dt.AsEnumerable().ToList();
			}


			catch 
			{
				atributos = null;

			}
			finally
			{
				conn.Close();
			}
			return atributos;
		}

		public override string ToString()
		{
			return this.nombre;
		}
		public string GetNombre()
		{
			return this.nombre;
		}
	}
}
