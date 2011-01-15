using System.Collections.Generic;
using System.Linq;

namespace CheckOutKataXpMan
{
    internal class Catalogue
    {
        IList<Item> priceList = new List<Item>();

        public Catalogue()
        {
            

            priceList.Add(new Item {sku = "A", price = 50m});
            priceList.Add(new Item { sku = "B", price = 30m });
            priceList.Add(new Item {sku = "C", price = 20m});
            priceList.Add(new Item {sku = "D", price = 15m});
        }
        public decimal GetPrice(string sku)
        {
            return  priceList
                .Where(t => t.sku == sku)
                .Select(x => x.price)
                .Single();
     
        }
    }
}