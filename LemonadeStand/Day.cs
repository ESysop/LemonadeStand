using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{

	class Day
		{

		Store store;
		public double sellSetPrice;
		public int dayNumber;
		public Day ()
			{
			dayNumber = 1;
			}

		public void restockOption ()
			{
			Console.WriteLine("\n\nWould you like to go to the store to stock up on supplies?\n\n\t[Y] or[N]");
			string stockUp = Console.ReadLine();
			if (stockUp.ToUpper() == "Y")
				{
				store.showStoreMenu(); 
				}
			else
				{
				}
				Console.WriteLine("Your selling price per cup is set to $ " + (sellSetPrice) + "\nWould you like to change this?\n\n[Y] or [N]");
				string priceChange = Console.ReadLine();
				if (priceChange.ToUpper() == "Y")
					{
					Console.WriteLine("Enter the price you want to charge per cup for today.\n");

					decimal newPriceForToday = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("Todays price is ( $ " + (newPriceForToday) + " )");
					sellSetPrice = newPriceForToday;
					}
				else
					{
					Console.WriteLine("Lets Play.");
					}

				}
		public void dayPlay ()
			{
			Weather getWeatherReport = new Weather();
			RandomGenerator t100 = new RandomGenerator();
			t100.TempGen100();
			RandomGenerator r4 = new RandomGenerator();
			r4.RandGen4();
			Console.WriteLine("Todays actual weather is -- " + (getWeatherReport.weatherConditionsList[r4.R4]) + " With a high Temperature of " + (t100.T100) + "°");
			Console.WriteLine("\n\n Here come the customers!!\n\n");

			}
		}
	}