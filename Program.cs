using System;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioPOO01
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Transporte> transportes = new List<Transporte>
			{
			new Automovil(4, "AutoUno"),
			new Automovil(2, "AutoDos"), 
			new Automovil(3, "AutoTres"),
			new Automovil(1, "AutoCuatro"), 
			new Automovil(5, "AutoCinco"),
			new Avion(100, "AvionUno"),
			new Avion(30, "AvionDos"),
			new Avion(10, "AvionTres"),
			new Avion(25, "AvionCuatro"),
			new Avion(63, "AvionCinco"),

			};
		
			foreach (var transporte in transportes)
			{
				Console.WriteLine(transporte.MostrarCantidadPasajeros());
			}

			Console.ReadLine();
		
		}
	}
}
