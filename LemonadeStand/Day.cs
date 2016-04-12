using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{

	public class Day
		{
		public int weatherFactor, moodFactor, tempFactor, priceFactor,dayNumber,daysTemperature;
		public bool purchaseMade;
		public decimal sellSetPrice =.00M;
		Weather weather;
		List<Customer> customer;
		

		public Day ()
			{
			customer = new List<Customer>();
			weather = new Weather();
			}
		public void dayPlay ()
			{
			Console.Clear();
			weather.temperatureForcast();
			weather.temperatureCurrent();
			weather.weatherForcast();
			weather.weatherCurrent();
			Console.WriteLine("\nThe Forecast for today is \n\n" + (weather.forcastedWeatherCondition) + " With a high Temperature of " + (weather.forcastedTemperature) + "°");
			Console.WriteLine("\nTodays actual weather is -- " + (weather.todaysWeatherCondition ) + " With a high Temperature of " + (weather.todaysTemperature) + "°");
			Console.WriteLine("\n\n Here come the customers!!\n\n");
			Console.Read();
			}
		public void setSellingPriceForDay ()
			{
			Console.Clear();
			Console.WriteLine("\nYour selling price per cup is set to $ " + (sellSetPrice) + "\nWould you like to change this?\n\n[Y] or [N]");
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
			if (sellSetPrice >= .01M && sellSetPrice <= .26M)
				{
				priceFactor = 3;
				}
			else if (sellSetPrice >= .27M && sellSetPrice <= .51M) 
				{
				priceFactor = 2;
				}
			else if (sellSetPrice >= .52M && sellSetPrice <= .76M) 
				{
				priceFactor = 1;
				}
			else if (sellSetPrice >= .77M && sellSetPrice <1.51M) 
				{
				priceFactor = 0;
				}
			dayPlay();
			if (daysTemperature >= 15 && daysTemperature <= 40)
				{
				tempFactor = 0;
				}
			else if (daysTemperature >= 41 && daysTemperature <= 65)
				{
				tempFactor = 1;
				}
			else if (daysTemperature >= 66 && daysTemperature <= 90)
				{
				tempFactor = 2;
				}
			else if (daysTemperature >= 91 && daysTemperature <= 115)
				{
				tempFactor = 3;
				}
			}
	public void saleEvent ()
			{
			tempFactor = weather.todaysTemperature;
			if (weather.R4 + moodFactor + tempFactor + (priceFactor) >= 8) purchaseMade = true;
			}
		}
	}
	

		
	