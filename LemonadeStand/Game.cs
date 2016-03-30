using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Game
		{
			Store menu = new Store();
			SplashScreen splashscreen;
			Weather getWeatherCondition = new Weather();
			Temperature getTemperatureCondition = new Temperature();
			Customer makeCustomerList = new Customer();
		public Game ()

			{
			splashscreen = new SplashScreen(menu);
			}


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
	
