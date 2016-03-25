using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Temperature
		{
		public Temperature () { }

		public void getTemperature ()
			{
			for (int i = 0; i < 100; i++)
				{

				RandomGenerator t100 = new RandomGenerator();
				t100.TempGen100();
				Console.WriteLine("The temperature is " +(t100.T100) + ", ");
				Thread.Sleep(20);
				}
			}
		}

	}
