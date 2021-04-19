using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionesExcepciones
{
	public class Punto1
	{
		public static void Dividir(int NumeroUno)
		{
			try
			{

				int division = NumeroUno / 0;
			}

			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Operacion finalizada");
			}
		}
	}
}
