namespace BigBucksCoffee
{
    public interface IBeverage
    {
        int ID { get; set; }
        string Name { get; set; }
        string Discription { get; set; }
        string Image { get; set; }
        double Price { get; set; }

        string ToString();
    }
}