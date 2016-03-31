using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class PaperCups
		{
		public PaperCups ()
			{ }

		public decimal paperCupUnitPrice1 = .75M;
		public decimal paperCupUnitPrice2 = 1.75M;
		public decimal paperCupUnitPrice3 = 3.50M;

		public int cupsOnHand;
	
		public void buyMoreCups (Purse purse)
			{
			Console.WriteLine("You have $" + (purse.purseBalance) + " in your cashbox.\n\n");
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cups\n[2]\t300 Cups\n[3]\t750 Cups");
			string usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				cupsOnHand += 100;
				purse.purseBalance -= paperCupUnitPrice1;
				}
			else if (usersChoice == "2")
				{
				cupsOnHand += 300;
				purse.purseBalance -= paperCupUnitPrice2;
				}
			else if (usersChoice == "3")
				{
				cupsOnHand += 750;
				purse.purseBalance -= paperCupUnitPrice3;
				}
			Console.WriteLine("\nYou now have this many Paper Cup units : " + (cupsOnHand) + "\nThis is your new balance " + (purse.purseBalance));
			}
		}
	}
