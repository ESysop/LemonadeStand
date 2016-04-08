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
		Weather getWeatherReport ;
		public Temperature ()
			{
			getWeatherReport = new Weather();
			}
		

		public void getTemperature ()
			{
				RandomGenerator t100 = new RandomGenerator();
				t100.TempGen100();
				RandomGenerator r4 = new RandomGenerator();
				r4.RandGen4();
				Console.WriteLine("The Forecast for today  is ", (getWeatherReport.weatherConditionsList[r4.R4]), "With a high Temperature of ", (t100.T100) , "°");
			}
		}
	}
