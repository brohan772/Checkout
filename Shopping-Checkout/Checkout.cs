using Shopping_Checkout;
using System.Collections.Generic;
using System.Linq;


namespace Shopping_Checkout
{
    public class Checkout : ICheckout
    {
        private List<ItemPrices> _itemPrices;
        private Dictionary<string, int> _scannedItems;

        public Checkout()
        {
            _itemPrices = new List<ItemPrices>();
            _scannedItems = new Dictionary<string, int>();
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
            //if scanned item has already been scanned, increment it's quantity by 1, if not then add the item to the dict
            if (_scannedItems.ContainsKey(item))
            {
                _scannedItems[item] += 1;
            }
            else
            {
                _scannedItems.Add(item, 1);
            }
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;

            foreach (var item in _scannedItems)
            {
                var sku = item.Key;
                var quantity = item.Value;

                var itemPrice = _itemPrices.FirstOrDefault(i => i.SKU == sku);

                if (itemPrice != null)
                {
                    totalPrice += itemPrice.UnitPrice * quantity;
                }
            }
            return totalPrice;
        }
    }
}
