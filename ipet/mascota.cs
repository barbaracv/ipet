using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
