using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Store
		{
		//public decimal sellingSetPrice = 0.00M;
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

		public void showStoreMenu (Player player)
			{
			Console.WriteLine("\nThank you for shopping at Buyin Large, What would you like to purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice");

			string storeChoice = Console.ReadLine();
			if (storeChoice == "1")
				{
				 buyMoreCups();
				}
			else if (storeChoice == "2")
				{
				buyMoreLemons();
				}
			else if (storeChoice == "3")
				{
				buyMoreSugar();
				}
			else if (storeChoice == "4")
				{
				buyMoreIce();

				}
			else
				{
				Console.WriteLine("Please enter one of the store choices ");
				showStoreMenu(player);
				}

			}


	
		public void buyMoreCups (Player player )
			{
			Console.WriteLine("You have $" + () + " in your cashbox.\n\n");
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cups\n[2]\t300 Cups\n[3]\t750 Cups");
			string usersChoice = Console.ReadLine();


			if (usersChoice == "1")
				{
				cupsOnHand += 100;
				player.purseBalance -= paperCupUnitPrice1;
				}
			else if (usersChoice == "2")
				{
				cupsOnHand += 300;
				player.purse.purseBalance -= paperCupUnitPrice2;
				}
			else if (usersChoice == "3")
				{
				cupsOnHand += 750;
				player.purse.purseBalance -= paperCupUnitPrice3;
				}
			Console.WriteLine("\nYou now have this many Paper Cup units : " + (cupsOnHand) + "\nThis is your new balance " + (purse.purseBalance));
			}




		public void buyMoreLemons (Player player)
			{
			Console.WriteLine("Select a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons");
			string usersChoice = Console.ReadLine();


			if (usersChoice == "1")
				{
				lemonsOnHand += 10;
				player.purse.purseBalance -= lemons10Units;

				}
			else if (usersChoice == "2")
				{
				lemonsOnHand += 25;
				player.purse.purseBalance -= lemons25Units;
				}
			else if (usersChoice == "3")
				{
				lemonsOnHand += 75;
				player.purse.purseBalance -= lemons75Unit;


				}
			Console.WriteLine("\nYou now have this many Lemon units : " + (lemonsOnHand) + "\n\nThis is your new balance $ " + (purse.purseBalance));
			}



		

		public void buyMoreSugar (Player player)
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t10 Cups\t + (\n[2]\t30 Cups\n[3]\t75 Cups");
			string usersChoice = Console.ReadLine();

			if (usersChoice == "1")
				{
				sugarOnHand += 10;
				player.purse.purseBalance -= sugarUnitPrice1;
				}
			else if (usersChoice == "2")
				{
				sugarOnHand += 30;
				player.purse.purseBalance -= sugarUnitPrice2;
				}
			else if (usersChoice == "3")
				{
				sugarOnHand += 75;
				player.purse.purseBalance -= sugarUnitPrice3;
				}
			Console.WriteLine("\nYou now have this many Sugar units : " + (sugarOnHand) + "\nThis is your new balance " + ());
			}




		public void buyMoreIce (Player player)
			{
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cube\n[2]\t300 Cubes\n[3]\t750 Cubes");
			string usersChoice = Console.ReadLine();
						
			if (usersChoice == "1")
				{
				for (int i = 0; i < 100; i++)
					{
					player.inventory.iceList.Add(new Ice());
					}
				player.purse.purseBalance -= ice100Unit;

				}
			else if (usersChoice == "2")
				{
				for (int i = 0; i < 300; i++)
					{
					player.inventory.iceList.Add(new Ice());
					}
				player.purse.purseBalance -= ice300Unit;
				}
			else if (usersChoice == "3")
				{
				for (int i = 0; i < 750; i++)
					{
					player.inventory.iceList.Add(new Ice());
					}
				player.purse.purseBalance -= ice750Unit;
				}
			Console.WriteLine("\nYou now have this many ice units : " + (player.inventory.iceList) + "\nThis is your new balance " + (player.purse.purseBalance));
			}
	
			}


		}
	}
}


