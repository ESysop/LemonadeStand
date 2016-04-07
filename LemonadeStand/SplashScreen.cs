using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class SplashScreen : Game
		{
		public SplashScreen (Store store)
			{
				
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


		}
		
	}
		
	
