using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    public class Cart
    {
        private IBeverageRepo _repo;
        public List<string> ItemInfo;
        public int ItemCount { get; set; }
        public double TotalPrice { get; set; }
        public double TotalPriceIncBtw { get; set; }

        public Cart()
        {
            _repo = new BeverageRepo();
            ItemInfo = new List<string>();
        }

        public void AddToCart(int id, int amount)
        {
            IBeverage beverage = _repo.GetBeverage(id);
            ItemCount += amount;
            TotalPrice += amount * beverage.Price;
            TotalPriceIncBtw = CalcBtw(TotalPrice);
            ItemInfo.Clear();
            ItemInfo.Add(beverage.Name);
            ItemInfo.Add(Convert.ToString(amount));
            ItemInfo.Add(Convert.ToString(beverage.Price));
            ItemInfo.Add(Convert.ToString(beverage.Price * amount));
        }

        public double CalcBtw(double price)
        {
            return price * 1.21;
        }
    }
}