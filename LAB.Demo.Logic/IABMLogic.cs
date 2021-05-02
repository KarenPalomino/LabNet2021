using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Entities;

namespace LAB.Demo.Logic
{
	interface IABMLogic<P>
	{
		List<P> GetAll();
		void Add(P newProduct);

		void Delete(int id);
	}
}
