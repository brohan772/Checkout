using System.Collections.Generic;

namespace Shopping_Checkout
{
    public class DiscountPrices
    {
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public int DiscountPrice { get; set; }

        public DiscountPrices(string sku, int quantity, int discountPrice)
        {
            SKU = sku;
            Quantity = quantity;
            DiscountPrice = discountPrice;
        }
    }
}
