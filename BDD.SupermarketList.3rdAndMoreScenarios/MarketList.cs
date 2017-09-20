using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.SupermarketList._3rdAndMoreScenarios
{
    public class MarketList
    {
        public List<MarketProduct> Contents { get; set; }

        public MarketList()
        {
            Contents = new List<MarketProduct>();
        }

        internal void Add(MarketProduct product)
        {
            Contents.Add(product);
        }

        internal int GetQuantity(string v)
        {
            var product = Contents.Find(x=>x.Description == v);
            if (product == null)
                return 0;

            return product.Quantity;
        }

        internal void Remove(string p0)
        {
            var product = Contents.Find(x => x.Description == p0);
            Contents.Remove(product);
        }

        internal void Remove(string p1, int p0)
        {
            var product = Contents.Find(x => x.Description == p1);
            if (p0 > product.Quantity)
                product.Quantity = 0;
            else
                product.Quantity = product.Quantity - p0;
        }
    }

    public class MarketProduct
    {
        public String Description { get; set; }
        public int Quantity { get; set; }

        public MarketProduct()
        {
            this.Description = "";
            this.Quantity = 0;
        }

        public MarketProduct(String Description, int Quantity)
        {
            this.Description = Description;
            this.Quantity = Quantity;
        }
    }
}
