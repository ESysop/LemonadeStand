using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Customer
		{
		
		public Customer()
			{ }
		RandomGenerator mood = new RandomGenerator();
		public List<int> customerList = new List<int>();

		public void makeCustomers ()
			{
			for (int i = 0; i < 100; i++)
				{
				mood.RandGen4();
				int moodFactor = mood.R4;
				customerList.Add(moodFactor);

				}
			}
		}
	}
