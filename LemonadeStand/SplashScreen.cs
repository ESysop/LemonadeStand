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
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			
			Console.WriteLine("Welcome to the Lemonade Stand\n\tThe gold standard in Lemonade Stands\n\n");
			RandomGenerator t100 = new RandomGenerator();
			t100.TempGen100();
			RandomGenerator r4 = new RandomGenerator();
			r4.RandGen4();
			Console.WriteLine("The Forecast for today is " + (getWeatherReport.weatherConditionsList[r4.R4]) + " With a high Temperature of " + (t100.T100)+ "°");

			}
		public void restockOption ()
			{
			Console.WriteLine("Would you like to go to the store to stock up on supplies?\n\n\t[Y] or[N]"	);
			string stockUp = Console.ReadLine();
			if (stockUp.ToUpper() == "Y")
				{

				menu.getStoreMenu();

				}
			else
				{
				// set price for the day
				}
			}

		}
	}
