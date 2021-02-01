using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class DynamicControls : Form
    {
        private IBeverageRepo beverageRepo;

        private UserControlCart _cartControl = new UserControlCart();

        private ICart _cart;

        public DynamicControls()
        {
            //compositie: dit object heeft die klasse nodig, instanties gemaakt
            InitializeComponent();
            beverageRepo = BeverageRepo.GetSingletonRepo();
            _cart = Cart.GetCart();

            //beverages ophalen en controls genereren
            var beverages = beverageRepo.GetBeverages();
            GenerateControlsForBeverages(beverages);
            ShowCart();
        }

        private void ShowCart()
            //plakken van element: 
        {
            flowLayoutPanel2.Controls.Add(_cartControl);
        }

        private void AddToCart(int beverageId, int amount)
        {
            _cart.AddToCart(beverageId, amount);
            _cartControl.PrintOrders();
        }

        private void ButtonAddToCartInUserControlWasClicked(object sender, EventArgs e)
        {
            //listener: als onderstaande methode uitgevoerd wordt, (buttonaddtocartclickedinusercontrol) voer deze code uit
            //dus uitgevoerd elke keer als button add to cart geklikt wordt in een van z'n children, wordt deze code uitgevoerd
            var myControl = sender as MyUserControl;
            AddToCart(myControl.BeverageID, myControl.Amount);
        }


        //evt: inkorten code
        private void GenerateControlsForBeverages(IEnumerable<IBeverage> beverages)
        {
            foreach (IBeverage beverage in beverages)
            {
                if (beverage is Beer)
                {
                    Beer beer = beverage as Beer;
                    UserControlBeer UserControlBeer = new UserControlBeer()
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
                    //listener wordt uitgevoerd wanneer dat een buttonorderclicked in usercontrolbeer wordt aangevinkt
                    UserControlBeer.ButtonOrderClicked += ButtonAddToCartInUserControlWasClicked;
                    flowLayoutPanel1.Controls.Add(UserControlBeer);
                }
                else if (beverage is Soda)
                {
                    Soda soda = beverage as Soda;
                    UserControlSoda UserControlSoda = new UserControlSoda()
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image,
                        Extras = soda.Extras,
                        WithSugar = soda.WithSugar
                    };
                    UserControlSoda.ButtonOrderClicked += ButtonAddToCartInUserControlWasClicked;

                    flowLayoutPanel1.Controls.Add(UserControlSoda);
                }
                else if (beverage is Smoothie)
                {
                    Smoothie smoothie = beverage as Smoothie;
                    UserControlSmoothie UserControlSmoothie = new UserControlSmoothie()
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image,
                        ExtraFruits = smoothie.ExtraFruits,
                        BeverageSize = smoothie.Size
                    };
                    UserControlSmoothie.ButtonOrderClicked += ButtonAddToCartInUserControlWasClicked;

                    flowLayoutPanel1.Controls.Add(UserControlSmoothie);
                }
                else
                {
                    MyUserControl myUserControl = new MyUserControl()
                    {
                        BeverageID = beverage.ID,
                        BeverageName = beverage.Name,
                        Description = beverage.Discription,
                        Price = beverage.Price.ToString(),
                        Image = beverage.Image,
                    };

                    myUserControl.ButtonOrderClicked += ButtonAddToCartInUserControlWasClicked;

                    //op einde allemaal mooi aan panel toevoegen
                    flowLayoutPanel1.Controls.Add(myUserControl);
                }
            }
        }
    }
}