namespace BigBucksCoffee
{
    public interface ICart
    {
        int ItemCount { get; set; }
        double TotalPrice { get; set; }
        double TotalPriceIncBtw { get; set; }

        void AddToCart(int id, int amount);
    }
}