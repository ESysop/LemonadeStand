using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class SplashScreen
		{
		public SplashScreen ()
			{ }
		public void printSplashScreen ()
			{
			Weather getWeatherReport = new Weather();
			//string todaysForecast = getWeatherReport.getWeather;
			Console.Title = "Lemonade Stand";
			Console.BackgroundColor = ConsoleColor.Blue;
			//Console.Beep(337, 200);
			//Console.Beep(637, 300); Console.Beep(1337, 400); Console.Beep(2337, 500);
			Console.WriteLine("Welcome to the Lemonade Stand\n\nThe gold standard in Lemonade Stands\n\n");
			//Console.WriteLine("Todays Weather Forcast is ", (getWeatherReport.getWeatherReport));

			}

		}
	}
