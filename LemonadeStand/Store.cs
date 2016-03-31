using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Store
		{// Member variables declared here so they can be accessed throu store
		public Ice goToBuyIceMenu;
		public Lemons goToBuyMoreLemonsMenu;
		public Sugar goToBuyMoreSugarMenu;
		public PaperCups goToBuyCupsMenu;
		public Purse purse;
		public decimal sellSetPrice = 0.00M;


		public Store ()//instantiate 1 time in the constructor
			{
			goToBuyIceMenu = new Ice();
			goToBuyCupsMenu = new PaperCups();
			goToBuyMoreSugarMenu = new Sugar();
			goToBuyMoreLemonsMenu = new Lemons();
			purse = new Purse();

			}

		public void getStoreMenu ()
			{
			Console.WriteLine("\nThank you for shopping at Buyin Large, What would you like to purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice");

			string storeChoice = Console.ReadLine();
			if (storeChoice == "1")
				{
				goToBuyCupsMenu.buyMoreCups(purse);
				}
			else if (storeChoice == "2")
				{
				goToBuyMoreLemonsMenu.buyMoreLemons (purse);	
				}
			else if (storeChoice == "3")
				{
				goToBuyMoreSugarMenu.buyMoreSugar(purse);
				}
			else if (storeChoice == "4")
				{
				goToBuyIceMenu.buyMoreIce(purse);
				}

			}
		public void inventoryDisplay ()
			{
			Console.WriteLine("\nYour Current Inventory levels are as follows:\n\nCups\t" + (goToBuyCupsMenu.cupsOnHand) + "\nIce\t" + (goToBuyIceMenu.iceOnHand) + "\nSugar\t" + (goToBuyMoreSugarMenu.sugarOnHand) + "\nLemons\t" + (goToBuyMoreLemonsMenu.lemonsOnHand)  );//waterOnHand
			}
		}
	}


