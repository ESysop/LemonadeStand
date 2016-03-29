using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Lemons
		{
		public Lemons ()
			{ }
		Store store = new Store();
		//Store lemons = new Store();
		public void buyMoreLemons ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons");
			string usersChoice = Console.ReadLine();
			//return usersChoice;

			if (usersChoice == "1")
				{
				store.units = 10;
				store.unitPrice = .75;
				
				}
			else if (usersChoice == "2")
				{
				store.units = 25;
				store.unitPrice = 1.75;
				}
			else if (usersChoice == "3")
				{
				store.units = 75;
				store.unitPrice = 2.75;

				
				}
			}
		}
	}