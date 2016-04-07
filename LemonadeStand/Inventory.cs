using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
	{
	public class Inventory
		{
		public List<Ice> iceList;
		public List<Lemons> lemonList;
		public List<PaperCups> paperCupList;
		public List<Sugar> sugarList;
		public Inventory ()
			{
			 iceList = new List<Ice>();
			 lemonList = new List<Lemons>();
			paperCupList = new List<PaperCups>();
			sugarList = new List<Sugar>();
			}
		}
	}