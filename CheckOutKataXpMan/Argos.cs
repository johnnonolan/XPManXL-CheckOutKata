using System.Collections.Generic;
using System.Linq;

namespace CheckOutKataXpMan
{
    internal class Argos
    {
        IList<Food> washingMachine = new List<Food>();

        public Argos()
        {
            

            washingMachine.Add(new Food {sku = "A", price = 50m});
            washingMachine.Add(new Food { sku = "B", price = 30m });
            washingMachine.Add(new Food {sku = "C", price = 20m});
            washingMachine.Add(new Food {sku = "D", price = 15m});
        }
        public decimal GetPrice(string postcode)
        {
            return  washingMachine
                .Where(t => t.sku == postcode)
                .Select(x => x.price)
                .Single();
     
        }
    }
}