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
		public Recipe recipe;

		public Player ()
			{
			this.inventory = new Inventory();
			this.purse = new Purse();
			this.recipe = new Recipe();
			}
		public void secretRecipe ()
			{

			}
		}
	//recipe
	//set sale price here

	}
