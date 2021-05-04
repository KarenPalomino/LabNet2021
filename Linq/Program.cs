using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
using Logic;

namespace Linq
{
	class Program
	{
		static void Main(string[] args)
		{
			using (NorthwindContext db = new NorthwindContext())
			{
				QuerysLogic querysLogic = new QuerysLogic();
				Console.WriteLine("Devolver objeto Customer");
				foreach (var item in querysLogic.Query1())
				{
					Console.WriteLine($"{item.ContactName}");
				}


				QuerysLogic querysLogic1 = new QuerysLogic();
				Console.WriteLine("Devolver todos los productos sin stock");
				foreach (var products in querysLogic1.Query2())
				{
					Console.WriteLine($"El producto: {products.ProductName} tiene en stock {products.UnitsInStock} unidades");
				}


				QuerysLogic querysLogic2 = new QuerysLogic();
				Console.WriteLine("Productos en stock cuyo precio es mayor a 3");
				foreach (var products in querysLogic2.Query3())
				{
					Console.WriteLine($"El producto: {products.ProductName} tiene en stock {products.UnitsInStock} y un precio de {products.UnitPrice} pesos");
				}


				QuerysLogic querysLogic3 = new QuerysLogic();
				Console.WriteLine("Devolver Customers de Washington");
				foreach (var customer in querysLogic3.Query4())
				{
					Console.WriteLine($"El cliente {customer.ContactName} es de la Region de {customer.Region}");
				}


				QuerysLogic querysLogic4 = new QuerysLogic();
				Console.WriteLine($"Devolver primer elemento o nulo de Products donde el ID sea 789");
				try
				{
					querysLogic4.Query5();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("No existe ID 789");
				}

				Console.WriteLine($"Devolver los nombres de los customers en minuscula");
				var query8 = from customer in db.Customers select customer.ContactName.ToLower();

					foreach (var item in query8)
					{
						Console.WriteLine($"{item.ToLower()}");
					}
				Console.WriteLine($"Devolver los nombres de los customers en Mayuscula");
				var query8bis = from customer in db.Customers select customer.ContactName.ToUpper();
					foreach (var item in query8bis)
					{
						Console.WriteLine($"{item.ToUpper()}");
					}

				Console.WriteLine($"Join Orders con Customers mostrando Customers de Washington y Fecha de Orden");
				var query9 = from order in db.Categories
								 join customer in db.Customers
								 on order.CustomerID equals customer.CustomerID
								 where customer.Region == "WA" && order.OrderDate > new DateTime(1 / 1 / 1997)
								 select order;

					foreach (var item in query9)
					{
						Console.WriteLine($"ID Customer: {item.CustomerID}, Fecha de orden: {item.OrderDate}");
					}

				QuerysLogic querysLogic5 = new QuerysLogic();
				Console.WriteLine($"Query para devolver los primeros 3 Customers de Washington");
					foreach (var item in querysLogic5.Query6())
					{
						Console.WriteLine($"El cliente {item.ContactName} es de la region de {item.Region}");
					}

				QuerysLogic querysLogic6 = new QuerysLogic();
				Console.WriteLine($"Query para devolver lista de productos ordenados por nombre");

					foreach (var item in querysLogic6.Query7())
					{
						Console.WriteLine($"El nombre del producto es: {item.ProductName}");
					}

				QuerysLogic querysLogic7 = new QuerysLogic();
				Console.WriteLine($"Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
					foreach (var item in querysLogic7.Query8())
					{
						Console.WriteLine($"El producto: {item.ProductName} tiene {item.UnitsInStock} unidades en stock");
					}

				Console.WriteLine($"Query para devolver las distintas categorías asociadas a los productos");
				   var query13 = from categorie in db.Categories
								 join customer in db.Customers
								 on order.CustomerID equals customer.CustomerID
								 where 
								 select order;
				foreach (var item in query13)
					{
						Console.WriteLine($"{item.Key}");
					}

				Console.WriteLine($"Query para devolver el primer elemento de una lista de productos");
				var query14 = db.Products.First();
					Console.WriteLine($"{query14.ProductName}");
	
				}
				Console.ReadLine();


			}


		}
	}

