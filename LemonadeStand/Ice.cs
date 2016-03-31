using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Ice 
		{

		public Ice () { }

		public decimal iceUnitPrice1 = .75M;
		public decimal iceUnitPrice2 = 1.75M;
		public decimal iceUnitPrice3 = 2.75M;


		public int iceOnHand;

		public void buyMoreIce (Purse purse)
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cube\n[2]\t300 Cubes\n[3]\t750 Cubes");
			string usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				iceOnHand += 100;
				purse.purseBalance -= iceUnitPrice1;
				}
			else if (usersChoice == "2") 
				{
				iceOnHand += 300;
				purse.purseBalance -= iceUnitPrice2;
				}
			else if (usersChoice == "3") 
				{
				iceOnHand += 750;
				purse.purseBalance -= iceUnitPrice3;
				}
			Console.WriteLine("\nYou now have this many ice units : " + (iceOnHand) + "\nThis is your new balance " + (purse.purseBalance));
			}
		}
	}
