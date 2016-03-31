using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Sugar
		{
		public Sugar ()
			{ }

		public int sugarOnHand;
		public decimal sugarUnitPrice1 = .75M;
		public decimal sugarUnitPrice2 = 2.00M;
		public decimal sugarUnitPrice3 = 6.50M;



		public void buyMoreSugar (Purse purse)
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t10 Cups\n[2]\t30 Cups\n[3]\t75 Cups");
			string usersChoice = Console.ReadLine();
			
			if (usersChoice == "1")
				{
				sugarOnHand += 10;
				purse.purseBalance -= sugarUnitPrice1;
				}
			else if (usersChoice == "2")
				{
				sugarOnHand += 30;
				purse.purseBalance -= sugarUnitPrice2;
				}
			else if (usersChoice == "3")
				{
				sugarOnHand += 75;
				purse.purseBalance -= sugarUnitPrice3;
				}
			Console.WriteLine("\nYou now have this many Sugar units : " + (sugarOnHand) + "\nThis is your new balance" + (purse.purseBalance));
			}

		}
	}
