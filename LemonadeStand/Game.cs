using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Game
		{
			Store menu ;
			SplashScreen splashscreen;
			Customer makeCustomerList = new Customer();

			public Game ()
			// in the constructor below we passed in 'menu' which is a new instantiation of 'store'
			{
			menu = new Store();
			splashscreen = new SplashScreen(menu);
			makeCustomerList = new Customer();
			}


			public void startGame ()
			
			
			{
				makeCustomerList.makeCustomers();

				splashscreen.printSplashScreen();
				menu.inventoryDisplay();
			//	splashscreen.restockOption();
			//	menu.inventoryDisplay();
			//	splashscreen.restockOption();
			//splashscreen.restockOption();
			//splashscreen.restockOption();
			//menu.inventoryDisplay();

		


			}



		}
	}
	
