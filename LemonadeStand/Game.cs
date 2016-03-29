using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Game
		{
		public Game ()

			{ }
			SplashScreen splashscreen = new SplashScreen();
			Weather getWeatherCondition = new Weather();
			Temperature getTemperatureCondition = new Temperature();
			Customer makeCustomerList = new Customer();
			Store menu = new Store();


			public void startGame ()
			
			
			{

				makeCustomerList.makeCustomers();

				splashscreen.printSplashScreen();
				menu.inventoryDisplay();
				splashscreen.restockOption();
				menu.inventoryDisplay();



	
			}



		}
	}
	
