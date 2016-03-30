using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Store
		{
		public Ice goToBuyIceMenu;
		public int lemonsOnHand;
		public int sugarOnHand ;
		public int waterOnHand ;
		public int cupsOnHand ;
		public int units ;
		public double unitPrice;

		public Store ()
			{
			goToBuyIceMenu = new Ice();
			}
		
		

		public void getStoreMenu ()
			{
						
		Console.WriteLine("Thank you for shopping at Buyin Large, What would you like to purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice");
			string storeChoice =Console.ReadLine();
			if (storeChoice == "1")
				{
					PaperCups goToBuyCupsMenu = new PaperCups(); goToBuyCupsMenu.buyMoreCups();
				}
			else if (storeChoice == "2")
				{
					Lemons goToBuyLemonsMenu = new Lemons(); goToBuyLemonsMenu.buyMoreLemons();
				}
			else if (storeChoice == "3")
				{
					Sugar goToBuySugarMenu = new Sugar() ;goToBuySugarMenu.buyMoreSugar();
				}
			else if (storeChoice =="4")
				{
					goToBuyIceMenu.buyMoreIce();
				}
			else
				{

				}

		
			}
		public void inventoryDisplay ()
			{
			Console.WriteLine("Your Current Inventory levels are as follows:\n\nCups\t" + (cupsOnHand) + "\nIce\t" + (goToBuyIceMenu.iceOnHand) + "\nSugar\t" + (sugarOnHand) + "\nLemons\t" + (lemonsOnHand) + "\nWater\t" + (waterOnHand));
			}
}
		}

	
