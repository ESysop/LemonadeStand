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
		public decimal lemonsUnitPrice1 = .75M;
		public decimal lemonsUnitPrice2 = 1.75M;
		public decimal lemonsUnitPrice3 = 2.75M;

		public int lemonsOnHand;
		
		public void buyMoreLemons (Purse purse)
			{
			Console.WriteLine("Select a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons");
			string usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				lemonsOnHand += 10;
				purse.purseBalance -= lemonsUnitPrice1;
				
				}
			else if (usersChoice == "2")
				{
				lemonsOnHand += 25;
				purse.purseBalance -= lemonsUnitPrice2;
				}
			else if (usersChoice == "3")
				{
				lemonsOnHand += 75;
				purse.purseBalance -= lemonsUnitPrice3;

				
				}
			Console.WriteLine("\nYou now have this many Lemon units : " + (lemonsOnHand) + "\nThis is your new balance" + (purse.purseBalance));
			}
		}
	}