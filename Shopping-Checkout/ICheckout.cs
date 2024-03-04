namespace Shopping_Checkout
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
