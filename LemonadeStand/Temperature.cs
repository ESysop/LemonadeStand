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
			int num = 0;
			//string todaysWeather = getWeatherReport.getWeather();

			for (int i = 0; i < 7; i++)
				{
				RandomGenerator t100 = new RandomGenerator();
				t100.TempGen100();
				Console.WriteLine("The Forecast for Day ", (num++), " is ","With a high Temperature of ", (t100.T100) , "°");
				
				Thread.Sleep(20);
				}
			}
		}

	}
