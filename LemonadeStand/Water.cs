using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	class Water
		{

		public int waterUnits;
		public decimal waterUnitPrice;


		public void buyMoreWater ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t1 Gallon\n[2]\t3 Gallons\n[3]\t10 Gallons");
			string usersChoice = Console.ReadLine();

			if (usersChoice == "1")
				{
				waterUnits = 1;
				waterUnitPrice = 1.50m;
				}
			else if (usersChoice == "2")
				{
				waterUnits = 3;
				waterUnitPrice = 4.00m;
				}
			else if (usersChoice == "3")
				{
				waterUnits = 10;
				waterUnitPrice = 11.00M;
				}

			}

		}
	}
