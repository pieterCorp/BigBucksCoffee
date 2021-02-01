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
                new Stella(1, "santa", "Description", 20, $"{PATH}santa.jpg", 5, true, "blond"),
                new Orval(2, "simp", "Description", 15, $"{PATH}simp.jpg", 5, false, "bruin"),
                new Soda(3, "Soda", "Description", 10, $"{PATH}key.jpeg", "extra's", false ),
                new Soda(4, "Coco", "Description", 12, $"{PATH}key.jpeg", "extra's", false ),
                new Smoothie(5, "smoothie", "Description", 20, $"{PATH}santa.jpg", false ,20),
                new Smoothie(6, "smooth", "Description", 30, $"{PATH}simp.jpg", true ,50),
                new Smoothie(7, "with", "Description", 35, $"{PATH}key.jpeg", false ,50),
                new Jupiler(1, "santa", "Description", 20, $"{PATH}santa.jpg", 5, true, "blond"),
                new Orval(1, "santa", "Description", 20, $"{PATH}Orval.jfif", 5, true, "blond")

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