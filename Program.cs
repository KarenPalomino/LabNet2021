using System;

namespace PracticaExtensionesExcepciones
{
	class Program
	{
		static void Main(string[] args)
		{
			Punto1.Dividir(25);
			Console.WriteLine("Finalizo Punto Uno");

			{
				{
					PuntoDos.Cuenta(36, 0);
					Console.WriteLine("Finalizo Punto Dos");
				}

				{
					try
					{
						Logic.IngreseSuContraseña();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine("Finalizo Punto Tres");
					}
				}
			}


			try
			{
				CustomException.ThrowCustomException();
			}
			catch (CustomException ex)
			{
				Console.WriteLine($"Se capturo el '{ex.Message}'");
				Console.WriteLine("Finalizo Punto Cuatro");
			}
			finally
			{
				Console.WriteLine("La funcion siempre pasa por el finally");
			}
		}
	}
}

