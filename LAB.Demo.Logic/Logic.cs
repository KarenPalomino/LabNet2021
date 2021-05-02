using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Data;

namespace LAB.Demo.Logic
{
	public class Logic
	{
		protected readonly NorthwindContext context;

		public Logic()
		{
			context = new NorthwindContext();
		}
	}
}
