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

		//public int iceOnHand ;
		public decimal iceUnitPrice;
		public string usersChoice;
		public int iceOnHand;
		public void buyMoreIce ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cube\n[2]\t300 Cubes\n[3]\t750 Cubes");
			usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				iceOnHand += 100;
				iceUnitPrice -= .75M;
				}
			else if (usersChoice == "2") 
				{
				iceOnHand += 300;
				iceUnitPrice -= 1.75M;
				}
			else if (usersChoice == "3") 
				{
				iceOnHand += 750;
				iceUnitPrice -= 2.75M;
				}
			Console.WriteLine("You now have this many ice units : " + (iceOnHand)+"\n" +(iceUnitPrice) + "will be deducted from your balance");
			}
		}
	}
