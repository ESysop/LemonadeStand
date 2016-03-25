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
			Console.Title = "Lemonade Stand";
			Console.BackgroundColor = ConsoleColor.Blue;	
			Console.WriteLine("Welcome to the Lemonade Stand/n/nThe gold standard in Lemonade Stands.");

			}

		}
	}
