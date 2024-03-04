using Shopping_Checkout;
using System.Collections.Generic;
using System.Linq;


namespace Shopping_Checkout
{
    public class Checkout : ICheckout
    {
        private List<ItemPrices> _itemPrices;
        public Checkout()
        {
            _itemPrices = new List<ItemPrices>();
        }

        public void SetItemPrices(List<ItemPrices> itemPrices)
        {
            _itemPrices = itemPrices;
        }

        public List<ItemPrices> GetItemPrices()
        {
            return _itemPrices;
        }


        public void Scan(string item)
        {
        }

        public int GetTotalPrice()
        {
            return 0;
        }
    }
}
