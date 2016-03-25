using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class RandomGenerator
		{

		public RandomGenerator ()
			{ }
		public int R4, T100;
		public void RandGen ()
			{
			Random rnd = new Random();
			R4 = rnd.Next(0, 4);
			}
		public void TempGen ()
			{
			Random rnd = new Random();
			T100 = rnd.Next(15, 116);
			}
		}
	}






