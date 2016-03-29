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

		public int iceUnits = 0;
		public double iceUnitPrice= 0;
		public string usersChoice;

		public void buyMoreIce ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cube\n[2]\t300 Cubes\n[3]\t750 Cubes");
			usersChoice = Console.ReadLine();
			

			if (usersChoice == "1")
				{
				iceUnits += 100;
				iceUnitPrice = .75;
				}
			else if (usersChoice == "2") 
				{
				iceUnits += 300;
				iceUnitPrice = .75;
				}
			else if (usersChoice == "3") 
				{
				iceUnits += 750;
				iceUnitPrice = .75;
				}
			}
		}
	}
