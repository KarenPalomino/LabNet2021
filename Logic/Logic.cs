using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
	public class QuerysLogic
	{
		NorthwindContext db = new NorthwindContext();

		public IQueryable<Customers> Query1()
		{
			return db.Customers.OrderBy(c => c.CustomerID);

		}

		public IQueryable<Products> Query2()
		{
			return from products in db.Products where products.UnitsInStock == 0 select products;
		}
		public IQueryable<Products> Query3()
		{
			return db.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).OrderBy(p => p.UnitPrice);
		}
		public IQueryable<Customers> Query4()
		{
			return db.Customers.Where(c => c.Region == "WA");
		}
		public IQueryable<Products> Query5()
		{
			return (IQueryable<Products>)db.Products.Where(p => p.ProductID == 789)
					 .FirstOrDefault(p => p.ProductID == 789);
		}
		public IQueryable<Customers> Query6()
		{
			return db.Customers.Where(c => c.Region == "WA").Take(3);
		}

		public IQueryable<Products> Query7()
		{
			return db.Products.OrderBy(p => p.ProductName);
		}
		public IQueryable<Products> Query8()
		{
			return db.Products;
		}

			}
}
