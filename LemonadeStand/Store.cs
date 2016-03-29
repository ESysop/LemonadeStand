using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Store
		{
		public int iceOnHand ;
		public int lemonsOnHand;
		public int sugarOnHand = 0;
		public int waterOnHand = 0;
		public int cupsOnHand = 0;
		public int units ;
		public double unitPrice;

		public Store ()
			{ }
		//Water goToBuyWaterMenu = new Water();
		public string storeChoice;

		public void getStoreMenu ()
			{
						
		Console.WriteLine("Thank you for shopping at Buyin Large, What would you like to purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice");
			storeChoice =Console.ReadLine();
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
					Ice goToBuyIceMenu = new Ice();	goToBuyIceMenu.buyMoreIce();
				}
			else
				{

				}

		
			}
		public void inventoryDisplay ()
			{
			Console.WriteLine("Your Current Inventory levels are as follows:\n\nCups\t" + (cupsOnHand) + "\nIce\t" + (iceOnHand) + "\nSugar\t" + (sugarOnHand) + "\nLemons\t" + (lemonsOnHand) + "\nWater\t" + (waterOnHand));
			}
}
		}

	
