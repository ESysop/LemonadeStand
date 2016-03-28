using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
	public class Weather
		{
		public string todaysWeather;

		public string[] weatherConditionsList = new string[4] { "Heavy Storms", "Chance of light rain", "Hazy and humid", "Clear and Sunny" };

		public Weather ()
		{}
			public void getWeather ()
			{
					
				RandomGenerator r4 = new RandomGenerator();
				r4.RandGen4();			

			}

		}




}
