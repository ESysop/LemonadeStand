using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class SplashScreen
		{
		Store menu;
		public SplashScreen (Store Menu)
			{
			menu = Menu;
			}
	

		public void printSplashScreen ()
			{
			Weather getWeatherReport = new Weather();
			Console.Title = "Lemonade Stand";
			Console.WriteLine("Welcome to the Lemonade Stand\n\n\tThe gold standard in Lemonade Stands\n\n");
			RandomGenerator t100 = new RandomGenerator();
			t100.TempGen100();
			RandomGenerator r4 = new RandomGenerator();
			r4.RandGen4();
			Console.WriteLine("The Forecast for today is \n\n" + (getWeatherReport.weatherConditionsList[r4.R4]) + " With a high Temperature of " + (t100.T100)+ "°");
			}

		public void restockOption ()
			{
			Console.WriteLine("\n\nWould you like to go to the store to stock up on supplies?\n\n\t[Y] or[N]"	);
			string stockUp = Console.ReadLine();
			if (stockUp.ToUpper() == "Y")
				{
				menu.getStoreMenu();
				}
			else
				{
				Console.WriteLine("Your selling price per cup is set to $ " + (menu.sellSetPrice)  + "\nWould you like to change this?\n\n[Y] or [N]");
				string priceChange = Console.ReadLine();
				if (priceChange.ToUpper() == "Y")		
					{
					Console.WriteLine("Enter the price you want to charge per cup for today.\n");
					decimal newPriceForToday = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("Todays price is ( $ "+ (newPriceForToday) + " )");
					menu.sellSetPrice = newPriceForToday;	
					}
				else
					{
					Console.WriteLine("Lets Play.");
					}

				}
			}
		public void dayPlay (Store PlayaDay)
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
