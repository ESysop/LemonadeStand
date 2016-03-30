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
		public decimal lemonUnitPrice;
		public int lemonUnits;
		Store store = new Store();
		
		public void buyMoreLemons ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons");
			string usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				lemonUnits += 10;
				lemonUnitPrice -= .75M;
				
				}
			else if (usersChoice == "2")
				{
				lemonUnits += 25;
				lemonUnitPrice -= 1.75M;
				}
			else if (usersChoice == "3")
				{
				lemonUnits += 75;
				lemonUnitPrice -= 2.75M;

				
				}
			}
		}
	}