using Shopping_Checkout;
using NUnit.Framework;
using System.Collections.Generic;

namespace Shopping_Checkout.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void SetItemPricesTest()
        {
            var checkout = new Checkout();

            var itemPrices = new List<ItemPrices>
            {
                new ItemPrices("A", 50)
            };

            checkout.SetItemPrices(itemPrices);

            Assert.AreEqual(itemPrices, checkout.GetItemPrices());
        }



    }
}
