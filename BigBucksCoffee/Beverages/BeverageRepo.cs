using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class BeverageRepo : IBeverageRepo
    {
        public List<IBeverage> GetBeverages()
        {
            const string PATH = "../../Images/Beverages/";
            var beverages = new List<IBeverage>
            {
                new Beer(1, "santa", "Description", 20, $"{PATH}santa.jpg", 5, true, "blond"),
                new Beer(2, "simp", "Description", 15, $"{PATH}simp.jpg", 5, false, "bruin"),
                new Soda(3, "Soda", "Description", 10, $"{PATH}key.jpeg", "extra's", false ),
                new Soda(4, "Coco", "Description", 12, $"{PATH}key.jpeg", "extra's", false ),
                new Smoothie(5, "smoothie", "Description", 20, $"{PATH}santa.jpg", false ,20),
                new Smoothie(6, "smooth", "Description", 30, $"{PATH}simp.jpg", true ,50)
            };

            return beverages;
        }

        public IBeverage GetBeverage(int id)
        {
            List<IBeverage> allBeverages = GetBeverages();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedBeverage = allBeverages.Where(x => x.ID == id).FirstOrDefault();

            return selectedBeverage;
        }
    }
}