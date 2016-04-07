using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Game
		{
		Day day;
		Store store;
		Player player;
		SplashScreen splashscreen;


		public Game ()

			{
			this.day = new Day();
			this.player = new Player();
			this.store = new Store();
			this.splashscreen = new SplashScreen(store);

			}


		public void startGame ()


			{

			splashscreen.printSplashScreen();
			store.showStoreMenu(this.player);



			}



		}
	}

