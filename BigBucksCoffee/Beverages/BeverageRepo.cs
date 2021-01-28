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
                new Beer(1, "santa", "Description", 20, $"{PATH}santa.jpg", 5, true, "a discription"),
                new Beer(2, "simp", "Description", 15, $"{PATH}simp.jpg", 5, false, "a discription"),
                new Soda(3, "key", "Description", 10, $"{PATH}key.jpeg", "extra's", true ),
            };

            return beverages;
        }

        public IBeverage GetBeverage(int id)
        {
            List<IBeverage> allBeverages = GetBeverages();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedPizza = allBeverages.Where(x => x.ID == id).FirstOrDefault();

            return selectedPizza;
        }
    }
}