using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Purse
		{
		public decimal purseBalance = 20.00M;
		public Purse ()
			{

			}
			public void showPurseBalance ()
			{
			Console.WriteLine(purseBalance);
			}
		}
	}

