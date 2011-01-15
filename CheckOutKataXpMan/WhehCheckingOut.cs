using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace CheckOutKataXpMan
{
    [Subject("ShoppingCart")]
    public class WhehCheckingOut
    {
        Establish that = () =>
            {
                shoppingCart = new ShoppingCart();
                shoppingCart.AddItem("A", 6);
            };

        Because of = () => result = shoppingCart.calculateGrandTotal();
        It Should_Apply_discount = ()=> result.ShouldEqual(260m);
        static ShoppingCart shoppingCart;
        static decimal result;
    }
}
