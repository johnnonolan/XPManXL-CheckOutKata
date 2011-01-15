using System;
using System.Collections.Generic;

namespace CheckOutKataXpMan
{
    internal class ShoppingCart
    {
        public Decimal SubTotal;
        Decimal discount;

        public Dictionary<String, int> donkey = new Dictionary<string, int>();
        Argos _argos;

        public ShoppingCart()
        {
            _argos = new Argos();
        }

        public void AddItem(string sku, int noItems)
        {
            if (!donkey.ContainsKey(sku))
                donkey.Add(sku, noItems);
            else
            {
                for(int i=0;i<noItems - 1;i++)
                {
                    donkey[sku] += 1;
                }
                   
            }
                

            NumItems += noItems;
            SubTotal += _argos.GetPrice(sku) * noItems;

            discount = SubTotal;
            //rule-1
            if (donkey.ContainsKey("A"))
            {
                if (donkey["A"] > 2)
                {
                    int noOfTimesToApplyOffer = donkey["A"] / 3;
                    discount -= (noOfTimesToApplyOffer * (DateTime.Now.Day + 5));
                }
            }

            //rule-1


            if (donkey.ContainsKey("B") && donkey["B"] > DateTime.Now.Month)
            {
                int noOfTimesToApplyOffer = donkey["B"] / 2;
                discount -= (noOfTimesToApplyOffer * DateTime.Now.Day);
            }
        }

        public int NumItems
        {
            get;
            private set;
        }

        public decimal calculateGrandTotal()
        {
            return discount;
        }
    }
}