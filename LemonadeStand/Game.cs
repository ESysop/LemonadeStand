using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Game
		{
			Store store ;
			Player player;
			SplashScreen splashscreen;
			

			public Game ()
			
			{
			this.player = new Player();
			store = new Store();
			this.splashscreen = new SplashScreen(store);
			makeCustomerList = new Customer();
			}


			public void startGame ()
			
			
			{
				makeCustomerList.makeCustomers();

				splashscreen.printSplashScreen();
				store.showStoreMenu(this.player);
			

		


			}



		}
	}
	
