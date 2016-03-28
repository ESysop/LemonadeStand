using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Temperature
		{
		public Temperature () { }
		Weather getWeatherReport = new Weather();

		public void getTemperature ()
			{
			//int num = 0;
			//string todaysWeather;

			//for (int i = 0; i < 7; i++)
				
				RandomGenerator t100 = new RandomGenerator();
				t100.TempGen100();
			RandomGenerator r4 = new RandomGenerator();
			r4.RandGen4();
			Console.WriteLine("The Forecast for today  is ", (getWeatherReport.weatherConditionsList[r4.R4]), "With a high Temperature of ", (t100.T100) , "°");
				
				//Thread.Sleep(20);
				
			}
		}

	}
