using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Customer
		{
		Random mood;
		
		public Customer()
			{
			mood = new Random();
			}
		public List<int> customerList = new List<int>();

		public void makeCustomer ()
			{
			for (int marks = 0; marks < 100; marks++)
				{
				int moodFactor = mood.Next(0,4);
				customerList.Add(moodFactor);
				}
			}
		}
	}
