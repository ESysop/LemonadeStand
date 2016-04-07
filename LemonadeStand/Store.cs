using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Store
		{
		
		public Purse purse;
		

		public decimal sellSetPrice = 0.00M;
		public decimal ice100Unit = .75M;
		public decimal ice300Unit = 1.75M;
		public decimal ice750Unit = 2.75M;
		public decimal lemons10Units = .75M;
		public decimal lemons25Units = 1.75M;
		public decimal lemons75Unit = 2.75M;
		public decimal cups100Unit = .75M;
		public decimal cups300Unit = 1.75M;
		public decimal cups750Unit = 3.50M;
		public decimal sugar10Unit = .75M;
		public decimal sugar30Unit = 2.00M;
		public decimal sugar75Unit = 6.50M;
		public Store ()
			{


			}
		public void buyMoreSugar ()
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t10 Cups\t + (\n[2]\t30 Cups\n[3]\t75 Cups");
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
			Console.WriteLine("\nYou now have this many Sugar units : " + (sugarOnHand) + "\nThis is your new balance " + ());
			}
		public void buyMoreCups ( )
			{
			Console.WriteLine("You have $" + () + " in your cashbox.\n\n");
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cups\n[2]\t300 Cups\n[3]\t750 Cups");
			string usersChoice = Console.ReadLine();


			if (usersChoice == "1")
				{
				cupsOnHand += 100;
				.purseBalance -= paperCupUnitPrice1;
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
		public void buyMoreLemons (Purse purse)
			{
			Console.WriteLine("Select a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons");
			string usersChoice = Console.ReadLine();


			if (usersChoice == "1")
				{
				lemonsOnHand += 10;
				purse.purseBalance -= lemons10Units;

				}
			else if (usersChoice == "2")
				{
				lemonsOnHand += 25;
				purse.purseBalance -= lemons25Units;
				}
			else if (usersChoice == "3")
				{
				lemonsOnHand += 75;
				purse.purseBalance -= lemons75Unit;


				}
			Console.WriteLine("\nYou now have this many Lemon units : " + (lemonsOnHand) + "\n\nThis is your new balance $ " + (purse.purseBalance));
			}

		public void buyMoreIce (Player player )
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cube\n[2]\t300 Cubes\n[3]\t750 Cubes");
			string usersChoice = Console.ReadLine();


			if (usersChoice == "1")
				{
				player.inventory.iceList.Add(new Ice());
				purse.purseBalance -= ice100Unit;
				}
			else if (usersChoice == "2")
				{
				iceOnHand += 300;
				purse.purseBalance -= ice300Unit;
				}
			else if (usersChoice == "3")
				{
				iceOnHand += 750;
				purse.purseBalance -= ice750Unit;
				}
			Console.WriteLine("\nYou now have this many ice units : " + (iceOnHand) + "\nThis is your new balance " + (purse.purseBalance));
			}

		public void showStoreMenu (Player player)
			{
			Console.WriteLine("\nThank you for shopping at Buyin Large, What would you like to purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice");

			string storeChoice = Console.ReadLine();
			if (storeChoice == "1")
				{
				paperCups.buyMoreCups(player);
				}
			else if (storeChoice == "2")
				{
				lemons.buyMoreLemons (playe);	
				}
			else if (storeChoice == "3")
				{
				sugar.buyMoreSugar(player);
				}
			else if (storeChoice == "4")
				{
				buyMoreIce(player);

				}
			else
				{
				Console.WriteLine("Please enter one of the store choices ");
				showStoreMenu();
				}

			}
		
			
		}
	}
}


