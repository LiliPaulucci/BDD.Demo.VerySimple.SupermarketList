using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.SupermarketList.SecondScenario
{
    public class MarketList
    {
        public List<object> Contents { get; set; }

        public MarketList()
        {
            Contents = new List<object>();
        }

        internal void Add(object product)
        {
            Contents.Add(product);
        }
    }
}
