using System.Collections.Generic;

namespace Shopping_Checkout
{
    public class ItemPrices
    {
        public string SKU { get; set; }
        public int UnitPrice { get; set; }

        public ItemPrices(string sku, int unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
        }
    }
}
