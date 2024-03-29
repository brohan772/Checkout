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

        [Test]
        public void ScanItemsTest()
        {
            var checkout = new Checkout();

            var itemPrices = new List<ItemPrices>
            {
                new ItemPrices("A", 50),
                new ItemPrices("B", 40)
            };

            checkout.SetItemPrices(itemPrices);
            checkout.Scan("A");
            checkout.Scan("B");

            Assert.AreEqual(90, checkout.GetTotalPrice());
        }

        [Test]
        public void SetDiscountPricesTest()
        {
            var checkout = new Checkout();

            var discountPrices = new List<DiscountPrices>
            {
                new DiscountPrices("A", 3, 140)
            };

            checkout.SetDiscountPrices(discountPrices);

            Assert.AreEqual(discountPrices, checkout.GetDiscountPrices());
        }

        [Test]
        public void ScanDiscountItemsTest()
        {
            var checkout = new Checkout();

            var itemPrices = new List<ItemPrices>
            {
                new ItemPrices("A", 50),
                new ItemPrices("B", 40)
            };

            var discountPrices = new List<DiscountPrices>
            {
                new DiscountPrices("A", 3, 130)
            };

            checkout.SetItemPrices(itemPrices);
            checkout.SetDiscountPrices(discountPrices);

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.AreEqual(170, checkout.GetTotalPrice());

        }

        [Test]
        public void ScanZeroItemsTest()
        {
            var checkout = new Checkout();

            var itemPrices = new List<ItemPrices>
            {
                new ItemPrices("A", 50),
                new ItemPrices("B", 40)
            };

            checkout.SetItemPrices(itemPrices);

            Assert.AreEqual(0, checkout.GetTotalPrice());
        }

        [Test]
        public void ScanMissingItemsTest()
        {
            var checkout = new Checkout();

            var itemPrices = new List<ItemPrices>
            {
                new ItemPrices("A", 50)
            };

            checkout.SetItemPrices(itemPrices);

            checkout.Scan("A");
            checkout.Scan("C");
            checkout.Scan("a");

            Assert.AreEqual(50, checkout.GetTotalPrice());

        }

        [Test]
        public void RemoveDiscountTest()
        {
            var checkout = new Checkout();

            var itemPrices = new List<ItemPrices>
            {
                new ItemPrices("A", 50),
                new ItemPrices("B", 40)
            };

            var discountPrices = new List<DiscountPrices>
            {
                new DiscountPrices("A", 3, 130)
            };

            checkout.SetItemPrices(itemPrices);
            checkout.SetDiscountPrices(discountPrices);

            checkout.RemoveDiscount("A");

            Assert.IsEmpty(checkout.GetDiscountPrices());
        }

    }
}
