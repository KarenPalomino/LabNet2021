using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionesExcepciones
{
	public class PuntoDos
	{
		public static void Cuenta(int i, int? j)
		{
			try
			{
				int division = i / j.Value;
				Console.WriteLine($"El resultado es {division}");

				if (j != 0)
				{
					;
				}
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Solo Chuck Norris divide por cero!");
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
				Console.WriteLine("Seguro ingreso una letra o no ingreso nada.");
			}
		}
	}
}