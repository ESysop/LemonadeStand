using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Game
		{
		int dayNumber = 1;
		Day day;
		Store store;
		Player player;

		public Game ()

			{
			this.day = new Day();
			this.player = new Player();
			this.store = new Store();
			}

		public void startGame ()
			{
			Console.WriteLine("Welcome to the Lemonade Stand\n\n\tThe gold standard in Lemonade Stands\n\nSince you have no ingredients let's go buy some.\n\n");
			player.inventory.inventoryReport();
			Console.WriteLine("\nDad gave you $"+(player.purse.purseBalance)+" to get started");
			restockOption(this.store);
			day.dayPlay();
			}

		public void restockOption (Store store)
			{
			Console.Write("\n\nWould you like to go to the store to stock up on supplies?\n\n\t[Y] or [N]\n");
			string stockUp = Console.ReadLine();
			if (stockUp.ToUpper() == "Y")
				{
				Console.Clear();
				store.showStoreMenu(this.player);
				}
			else
				{
				day.setSellingPriceForDay ();
				}
			}
		}
	}

