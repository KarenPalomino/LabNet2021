using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;

namespace LAB.Demo.Logic
{
	public class ProductsLogic : Logic, IABMLogic<Products>
	{
		public List<Products> GetAll()
		{
			return context.Products.ToList();
		}

		public void Add(Products newProduct)
		{
			context.Products.Add(newProduct);

			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var ProductoAEliminar = context.Products.Find(id);

			context.Products.Remove(ProductoAEliminar);

			context.SaveChanges();

		}

		public void Update(Products product)
		{
			var productUpdate = context.Products.Find(product.ProductID);

			productUpdate.ProductName = product.ProductName;

			context.SaveChanges();
		}
	}
}
