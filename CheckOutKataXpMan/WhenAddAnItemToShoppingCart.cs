using Machine.Specifications;

namespace CheckOutKataXpMan
{
    [Subject("ShoppingCart")]
    public class WhenAddAnItemToShoppingCart
    {
        Establish that = () => shoppingCart = new ShoppingCart();

        Because of = ()=>  shoppingCart.AddItem("A", 1);
        It should_increase_no_items = () => shoppingCart.NumItems.ShouldEqual(1);

        It should_increase_subtotal = () => shoppingCart.SubTotal.ShouldEqual(50m);
        static ShoppingCart shoppingCart;
    }
}
