using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Entities;

namespace LAB.Demo.Logic
{
	public class TerritoriesLogic : Logic, IABMLogic<Territories>
	{
		public void Add(Territories newProduct)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Territories> GetAll()
		{
			return context.Territories.ToList();
		}
	}
}
