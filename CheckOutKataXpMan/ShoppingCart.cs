using System;
using System.Collections.Generic;

namespace CheckOutKataXpMan
{
    internal class ShoppingCart
    {
        public Decimal SubTotal;

        public Dictionary<String, int> cart = new Dictionary<string, int>();
        Catalogue _catalogue;

        public ShoppingCart()
        {
            _catalogue = new Catalogue();
        }

        public void AddItem(string sku, int noItems)
        {
            if (!cart.ContainsKey(sku))
                cart.Add(sku, noItems);
            else
                cart[sku] += noItems;

            NumItems += noItems;
            SubTotal += _catalogue.GetPrice(sku) * noItems;

        }

        public int NumItems
        {
            get;
            private set;
        }

        public decimal calculateGrandTotal()
        {
            decimal grandTotal = SubTotal;
            //rule-1
            if (cart.ContainsKey("A") &&  cart["A"] > 2)
            {
                int noOfTimesToApplyOffer = cart["A"] / 3;
                grandTotal -= (noOfTimesToApplyOffer*20m);
            }

            //rule-1


            if (cart.ContainsKey("B") && cart["B"] > 1)
            {
                int noOfTimesToApplyOffer = cart["B"] / 2;
                grandTotal -= (noOfTimesToApplyOffer * 15m);
            }


            return grandTotal;
        }
    }
}