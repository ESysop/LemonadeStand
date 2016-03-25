using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	class Program
		{
		static void Main (string[] args)
			{
			Weather getWeatherCondition = new Weather();
			Temperature getTemperatureCondition = new Temperature();
			Customer makeCustomerList = new Customer();
			SplashScreen splashscreen = new SplashScreen();
			splashscreen.printSplashScreen();
			getWeatherCondition.getWeather();
			getTemperatureCondition.getTemperature();
			makeCustomerList.makeCustomers();

			}
		
		
		}

	}
