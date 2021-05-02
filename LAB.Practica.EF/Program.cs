using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Entities;
using LAB.Demo.Logic;

namespace LAB.Practica.EF.UI
{
	class Program
	{
		static void Main(string[] args)
		{

			{
				TerritoriesLogic territoriesLogic = new TerritoriesLogic();

				foreach (Territories territorie in territoriesLogic.GetAll())
				{
					Console.WriteLine($"ID de Territorio: {territorie.TerritoryID}, Descripcion: {territorie.TerritoryDescription}");
				}

				Console.WriteLine();

				ProductsLogic productsLogic = new ProductsLogic();

				foreach (Products product in productsLogic.GetAll())
				{
					Console.WriteLine($"Producto: {product.ProductName}, ID Producto {product.ProductID}, Precio: {product.UnitPrice}, Cantidad en Stock: {product.UnitsInStock}");
				}
				Console.WriteLine();

				Console.WriteLine("Agrego un nuevo producto");
				productsLogic.Add(new Products
				{
					ProductID = 82,
					ProductName = "Nuevo Producto",
					UnitPrice = 25,
					UnitsInStock = 20,
				});

				foreach (Products product in productsLogic.GetAll())
				{
					Console.WriteLine($"Producto: {product.ProductName},ID Producto {product.ProductID}, Precio: {product.UnitPrice}, Cantidad en Stock: {product.UnitsInStock}");
				}
				Console.WriteLine();
			
				Console.WriteLine("Cambio el nombre del producto");
				
				productsLogic.Update(new Products
				{
					ProductName = "Este es el nuevo Nombre del Producto",
					ProductID = 82,
				});
				Console.WriteLine();

				Console.WriteLine("Elimino el producto agregado");
				productsLogic.Delete(82);


				foreach (Products product in productsLogic.GetAll())
				{
					Console.WriteLine($"Producto: {product.ProductName},ID Producto {product.ProductID}, Precio: {product.UnitPrice}, Cantidad en Stock: {product.UnitsInStock}");
				}
				Console.ReadLine();

				
			}
		}
	}
}
