using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO01
{
	public abstract class Transporte
	{
		public int CantidadPasajeros;
		public string Nombre;

		public Transporte(int CantidadPasajeros, string Nombre)
		{
			this.CantidadPasajeros = CantidadPasajeros;
			this.Nombre = Nombre;
			
		}

		public abstract string Avanzar();

		public abstract string Detenerse();

		public string MostrarCantidadPasajeros()
		{
			return $"El {this.Nombre} contiene {this.CantidadPasajeros} pasajeros";
		}
}
}
