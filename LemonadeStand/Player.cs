using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
	{
	public class Player
		{
		public Inventory inventory;
		public Purse purse;

		public Player ()
			{
			this.inventory = new Inventory();
			this.purse = new Purse();
			}
		}
	

	}
