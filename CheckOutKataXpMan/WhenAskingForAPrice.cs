using System;
using Machine.Specifications;

namespace CheckOutKataXpMan
{
    [Subject("SKU")]
    public class WhenAskingForAPriceOfA
    {
        Establish that = () =>
                         catalogue = new Catalogue();

        Because of = () => result= catalogue.GetPrice("A");

        It gives_50_when_asking_price_of_A = () =>
                                             result.ShouldEqual(50m);

        static Decimal result;
        static Catalogue catalogue;
    }


    [Subject("SKU")]
    public class WhenAskingForAPriceOfB
    {
        Establish that = () =>
                         catalogue = new Catalogue();

        Because of = () => result = catalogue.GetPrice("B");

        It gives_30_when_asking_price_of_B = () =>
                                             result.ShouldEqual(30m);

        static Decimal result;
        static Catalogue catalogue;
    }
}
