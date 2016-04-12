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
		public int R4, T100;
		public string todaysWeatherCondition, forcastedWeatherCondition;
		public int todaysTemperature,forcastedTemperature;
		public string[] weatherConditionsList = new string[4] { "Heavy Storms", "Chance of light rain", "Hazy and humid", "Clear and Sunny" };

		public Weather ()
			{
			}
		
	public void temperatureForcast ()
			{
			Random rnd = new Random();
			T100 = rnd.Next(15, 116);
			todaysTemperature = T100;
			}
		public void temperatureCurrent ()
			{
			Random rand = new Random();
			int weatherShift = rand.Next(-10, 11);
			forcastedTemperature = todaysTemperature += weatherShift;
			}

		public void weatherForcast ()
			{
			Random rnd = new Random();
			R4 = rnd.Next(0, 4);
			forcastedWeatherCondition=weatherConditionsList[R4];
			}
		public void weatherCurrent ()
			{
			Random rando = new Random();
			int conditionShift = rando.Next(-1, 2);
			//int rangeCheck;
			if ((R4 += conditionShift) <= 0)
				{
				R4 = 0;
				}
			else if ((R4 += conditionShift) >= 3)
				{
				R4  =3;
				}
			todaysWeatherCondition = weatherConditionsList[R4];
			}
		}
}
