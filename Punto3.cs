using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionesExcepciones
{
	public abstract class Logic
	{
		public static string IngreseSuContraseña()
		{
			throw new Exception("La contraseña debe tener 8 caracteres");
		}
	}
}
