using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    public class Cart : ICart
    {
        private static Cart _cart;
        private IBeverageRepo _repo;
        //constructor private gemaakt, externe klasse kan geen nieuwe maken^

        public List<ItemInCart> ItemsInCart;
        public int ItemCount { get; set; }
        public double TotalPrice { get; set; }
        public double TotalPriceIncBtw { get; set; }

        private Cart()
        {
            _repo = BeverageRepo.GetSingletonRepo();
            ItemsInCart = new List<ItemInCart>();
        }

        //we verbieden anderen om een cart aan te maken, maar ze mogen er wel om vragen
        public static Cart GetCart()
        {
            if (_cart == null)
            {
                _cart = new Cart();
            }
            return _cart;
        }

        public void AddToCart(int id, int amount)
        {
            IBeverage beverage = _repo.GetBeverage(id);
            ItemCount += amount;
            TotalPrice += amount * beverage.Price;
            TotalPriceIncBtw = CalcBtw(TotalPrice);

            var item = new ItemInCart
            {
                Name = beverage.Name,
                Amount = amount,
                SinglePrice = beverage.Price,
                TotalPrice = beverage.Price * amount
            };

            ItemsInCart.Add(item);
        }

        public double CalcBtw(double price)
        {
            return price * 1.21;
        }
    }
}