using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class BeverageRepo : IBeverageRepo
    {
        //door static rechtstreeks klasse aanspreken
        private static IBeverageRepo _repo;
        private IList<IBeverage> _beverages;

        private BeverageRepo()
        {
            _beverages = SetupInitialBeverages();
        }
        public static IBeverageRepo GetSingletonRepo()
        {
            if (_repo == null)
            {
                _repo = new BeverageRepo();
            }
            return _repo;
        }

        public IList<IBeverage> GetBeverages()
        {
            return _beverages;
        }

        public void AddBeverage(IBeverage beverage)
        {
            _beverages.Add(beverage);
        }

        const string PATH = "../../Images/Beverages/";

        private List<IBeverage> SetupInitialBeverages()
        {

            var beverages = new List<IBeverage>
            {
                
                new Orval(1, "Orval", "Pieter heeft er zin in", 4, $"{PATH}Orval.jfif", 6, false, "bruin"),
                new Jupiler(2, "Jupiler", "als er geen Stella is", 2, $"{PATH}Jupiler.jfif", 5, false, "pils"),
                new Stella(3, "Stella aka godendrank", "beter dan water", 2, $"{PATH}Stella.jfif", 5, false, "pils"),
                new CocaCola(4, "Cola", "geen pepsi", 3, $"{PATH}Cola.jfif", "citroentje", true),
                new IceTea(5, "Ice-Tea", "voor alsde nen kater hebt en nog niet wilt drinken maar beter dan water", 3, $"{PATH}Ice-Tea.jfif", "citroentje én appelsientje", true, true),
                new Banana(6, "banana smoothie", "melk en banaan, met beetje yoghurt, gemixt", 4, $"{PATH}Banana.jfif", true, 10),
                new Strawberry(7, "strawberry smoothie", "aardbei en melk en yoghurt en mixen", 5, $"{PATH}Strawberry.jfif", true, 20),
            };

            return beverages;
        }

        public IBeverage GetBeverage(int id)
        {
            IList<IBeverage> allBeverages = GetBeverages();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedBeverage = allBeverages.Where(x => x.ID == id).FirstOrDefault();

            return selectedBeverage;
        }


    }
}