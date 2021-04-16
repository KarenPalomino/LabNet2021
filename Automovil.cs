using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO01
{
	public class Automovil : Transporte
	{
		public Automovil (int CantidadPasajeros, string Nombre):base(CantidadPasajeros, Nombre)
		{
		}

		public override string Avanzar()
		{
			throw new NotImplementedException();
		}

		public override string Detenerse()
		{
			throw new NotImplementedException();
		}
		
	}
}