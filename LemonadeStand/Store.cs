using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Store
		{
		
		public decimal singleIceCube = .0075M, singleLemon = .075M, singleCupOfSugar = .075M, singlePaperCup = .0075M;
		public decimal ice100Unit = .75M, ice300Unit = 1.75M, ice750Unit = 2.75M;
		public decimal lemons10Units = .75M, lemons25Units = 1.75M, lemons75Units = 2.75M;
		public decimal cups100Unit = .75M, cups300Unit = 1.75M, cups750Unit = 3.50M;
		public decimal sugar10Unit = .75M, sugar30Unit = 2.00M, sugar75Unit = 6.50M;

		public Store ()
			{
			}
		public void showStoreMenu (Player player)
			{
			Console.WriteLine("\n\nThank you for shopping at...\n\n\t\tThe Grocery Glutten,\n\nWhat would you like to over purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice\n\n");
			Console.Write("Please enter one of the store choices or ANY other Key when your done making purchases");

			string storeChoice = Console.ReadLine();
					if (storeChoice == "1")
						{
						buyMoreCups(player);
						}
					else if (storeChoice == "2")
						{
						buyMoreLemons(player);
						}
					else if (storeChoice == "3")
						{
						buyMoreSugar(player);
						}
					else if (storeChoice == "4")
						{
						buyMoreIce(player);
						}
					else
						{
				//day.dayPlay();
						}
			}

		public void buyMoreCups (Player player)
			{
			Console.WriteLine("You have $" + (player.purse.purseBalance) + " in your cashbox.\n\n");
			Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cups\n[2]\t300 Cups\n[3]\t750 Cups\n\n");
			Console.Write("Your choice ");
			string usersChoice = Console.ReadLine();

			if (usersChoice == "1")
				{
				for (int i = 0; i < 100; i++)
					{
					player.inventory.paperCupList.Add(new PaperCups());
					}
				player.purse.purseBalance -= cups100Unit;
				}
			else if (usersChoice == "2")
				{
				for (int i = 0; i < 300; i++)
					{
					player.inventory.paperCupList.Add(new PaperCups());
					}
				player.purse.purseBalance -= cups300Unit;
				}
			else if (usersChoice == "3")
				{
				for (int i = 0; i < 750; i++)
					{
					player.inventory.paperCupList.Add(new PaperCups());
					}
				player.purse.purseBalance -= cups750Unit;
				}
			player.inventory.inventoryReport();
			Console.WriteLine("\nThis is your new cashbox balance " + (player.purse.purseBalance));
			showStoreMenu(player);
			}



		public void buyMoreLemons (Player player)
			{
			Console.WriteLine("\nSelect a quantity for your order.\n\n [1] \t  10 Lemons \n [2] \t 25 Lemons \n [3] \t  75 Lemons\n");
			Console.Write("Your choice ");
			string usersChoice = Console.ReadLine();

			if (usersChoice == "1")
				{
				for (int lemons = 0; lemons < 10; lemons++)
					{
					player.inventory.lemonList.Add(new Lemons());
					}
				player.purse.purseBalance -= lemons10Units;
				}
			else if (usersChoice == "2")
				{
				for (int lemons = 0; lemons < 25; lemons++)
					{
					player.inventory.lemonList.Add(new Lemons());
					}
				player.purse.purseBalance -= lemons25Units;
				}
			else if (usersChoice == "3")
				{
				for (int lemons = 0; lemons < 75; lemons++)
					{
					player.inventory.lemonList.Add(new Lemons());
					}
				player.purse.purseBalance -= lemons75Units;
				}
			Console.WriteLine("\n\nThis is your new cashbox balance $ " + (player.purse.purseBalance));
			showStoreMenu(player);
			}



		public void buyMoreSugar (Player player)
			{
			Console.WriteLine("\nSelect a quantity for your order.\n\n[1]\t10 Cups\n[2]\t30 Cups\n[3]\t75 Cups");
			string usersChoice = Console.ReadLine();
			Console.Write("Your choice ");

			if (usersChoice == "1")
				{
				for (int i = 0; i < 100; i++)
					{
					player.inventory.sugarList.Add(new Sugar());
					}
				player.purse.purseBalance -= ice100Unit;
				}
			else if (usersChoice == "2")
				{
				for (int i = 0; i < 300; i++)
					{
					player.inventory.sugarList.Add(new Sugar());
					}
				player.purse.purseBalance -= ice300Unit;
				}
			else if (usersChoice == "3")
				{
				for (int i = 0; i < 750; i++)
					{
					player.inventory.sugarList.Add(new Sugar());
					}
				player.purse.purseBalance -= ice750Unit;
				}
			Console.WriteLine("\n\nYou now have this many Sugar units : " + (player.inventory.sugarList.Count) + "\n\nThis is your new balance " + (player.purse.purseBalance));
			showStoreMenu(player);
			}

		public void buyMoreIce (Player player)
			{
			Console.WriteLine("\nSelect a quantity for your order.\n\n[1]\t100 Cube\n[2]\t300 Cubes\n[3]\t750 Cubes");
			Console.Write("Your choice ");
			string usersChoice = Console.ReadLine();

			if (usersChoice == "1")
				{
				for (int i = 0; i < 100; i++)
					{
					player.inventory.iceList.Add(new Ice());
					player.purse.purseBalance -= singleIceCube;
					}

				}
			else if (usersChoice == "2")
				{
				for (int i = 0; i < 300; i++)
					{
					player.inventory.iceList.Add(new Ice());
					player.purse.purseBalance -= (singleIceCube*.8M);
					}
				}
			else if (usersChoice == "3")
				{
				for (int i = 0; i < 750; i++)
					{
					player.inventory.iceList.Add(new Ice());
					player.purse.purseBalance -= (singleIceCube*.8M);
					}
				}
			Console.WriteLine("\n\nYou now have this many ice units : " + (player.inventory.iceList.Count) + "\n\nThis is your new balance " + (player.purse.purseBalance));
			showStoreMenu(player);

			}

		}



	}



