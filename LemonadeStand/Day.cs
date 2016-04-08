using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{

	public class Day
		{

		
		public decimal sellSetPrice;
		public int dayNumber;
		public Day ()
			{
			dayNumber = 1;
			}
		public void dayPlay ()
			{
			Weather getWeatherReport = new Weather();
			RandomGenerator t100 = new RandomGenerator();
			t100.TempGen100();
			RandomGenerator r4 = new RandomGenerator();
			r4.RandGen4();
			Console.WriteLine("The Forecast for today is \n\n" + (getWeatherReport.weatherConditionsList[r4.R4]) + " With a high Temperature of " + (t100.T100) + "°");
			t100.TempGen100();
			r4.RandGen4();
			Console.WriteLine("Todays actual weather is -- " + (getWeatherReport.weatherConditionsList[r4.R4]) + " With a high Temperature of " + (t100.T100) + "°");
			Console.WriteLine("\n\n Here come the customers!!\n\n");

			}
		public void setSellingPriceForDay () { 
			
				Console.WriteLine("Your selling price per cup is set to $ " + (sellSetPrice) + "\nWould you like to change this?\n\n[Y] or [N]");
				string priceChange = Console.ReadLine();
				if (priceChange.ToUpper() == "Y")
					{
					Console.Write("\nEnter the price you want to charge per cup for today.\n");
				
					decimal newPriceForToday = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("\nTodays price is ( $ " + (newPriceForToday) + " )");
					sellSetPrice = newPriceForToday;
					}
				else
					{
					Console.WriteLine("\nLets Play.");
					}

				}
		
		}
	}