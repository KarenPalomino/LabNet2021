using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionesExcepciones
{
	public class CustomException : Exception
	{
		public static void ThrowCustomException()
		{
			throw new CustomException();
		}
		public CustomException() : base("Mensaje de Error de nuestra Custom Exception")
		{
		}

	}
}