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
		public decimal lemonsUnitPrice;
		public int lemonsOnHand;
		
		public void buyMoreLemons ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons");
			string usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				lemonsOnHand += 10;
				lemonsUnitPrice -= .75M;
				
				}
			else if (usersChoice == "2")
				{
				lemonsOnHand += 25;
				lemonsUnitPrice -= 1.75M;
				}
			else if (usersChoice == "3")
				{
				lemonsOnHand += 75;
				lemonsUnitPrice -= 2.75M;

				
				}
			Console.WriteLine("\nYou now have this many Lemon units : " + (lemonsOnHand) + "\n" + (lemonsUnitPrice) + "will be deducted from your balance");
			}
		}
	}