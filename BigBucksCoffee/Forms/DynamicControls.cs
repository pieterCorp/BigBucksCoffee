using System.Collections.Generic;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class DynamicControls : Form
    {
        private IBeverageRepo beverageRepo;

        public DynamicControls()
        {
            InitializeComponent();
            beverageRepo = new BeverageRepo();
            var beverages = beverageRepo.GetBeverages();
            GenerateControlsForBeverages(beverages);
        }

        private void GenerateControlsForBeverages(IEnumerable<IBeverage> beverages)
        {
            foreach (IBeverage beverage in beverages)
            {
                if (beverage is Beer)
                {
                    Beer beer = beverage as Beer;
                    UserControlBeer UserControlBeer = new UserControlBeer
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
                else
                {
                    MyUserControl myUserControl = new MyUserControl
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