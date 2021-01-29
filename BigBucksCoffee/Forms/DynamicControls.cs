using System.Collections.Generic;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class DynamicControls : Form
    {
        private IBeverageRepo beverageRepo;

        private UserControlCart _cartControl = new UserControlCart();

        public DynamicControls()
        {
            InitializeComponent();
            beverageRepo = new BeverageRepo();
            var beverages = beverageRepo.GetBeverages();
            GenerateControlsForBeverages(beverages);
            ShowCart();
        }

        private void ShowCart()
        {
            flowLayoutPanel2.Controls.Add(_cartControl);
        }

        private void GenerateControlsForBeverages(IEnumerable<IBeverage> beverages)
        {
            foreach (IBeverage beverage in beverages)
            {
                if (beverage is Beer)
                {
                    Beer beer = beverage as Beer;
                    UserControlBeer UserControlBeer = new UserControlBeer(_cartControl)
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image,
                        AlcoholPercentage = beer.AlcoholPercentage,
                        IsTrapist = beer.IsTrapist,
                        Type = beer.Type
                    };
                    flowLayoutPanel1.Controls.Add(UserControlBeer);
                }
                else if (beverage is Soda)
                {
                    Soda soda = beverage as Soda;
                    UserControlSoda UserControlSoda = new UserControlSoda(_cartControl)
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image,
                        Extras = soda.Extras,
                        WithSugar = soda.WithSugar
                    };
                    flowLayoutPanel1.Controls.Add(UserControlSoda);
                }
                else if (beverage is Smoothie)
                {
                    Smoothie smoothie = beverage as Smoothie;
                    UserControlSmoothie UserControlSmoothie = new UserControlSmoothie(_cartControl)
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image,
                        ExtraFruits = smoothie.ExtraFruits,
                        Size = smoothie.Size
                    };
                    flowLayoutPanel1.Controls.Add(UserControlSmoothie);
                }
                else
                {
                    MyUserControl myUserControl = new MyUserControl(_cartControl)
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image
                    };

                    flowLayoutPanel1.Controls.Add(myUserControl);
                }
            }
        }
    }
}