using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    class MakeNewBeverage
    {
        const string PATH = "../../Images/Beverages/";
        IBeverageRepo repo;

        public MakeNewBeverage()
        {
            repo = BeverageRepo.GetSingletonRepo();
            
        }

        public void MakeNewBeer(int id, string name, string description, double price, string img, int alcoholPercentage, bool isTrapist, string type)
        {
            Beer beer = new Stella(id, name, description, price, $"{PATH}{img}", alcoholPercentage, isTrapist, type);
            repo.AddBeverage(beer);
        }

        public void MakeNewSoda(int id, string name, string description, double price, string img, string extras, bool withSugar)
        {
            Soda soda = new CocaCola(id, name, description, price, $"{PATH}{img}", extras, withSugar);
            repo.AddBeverage(soda);
        }

        public void MakeNewSmoothie(int id, string name, string description, double price, string img, bool extraFruits, int size)
        {
            Smoothie smoothie = new Banana(id, name, description, price, $"{PATH}{img}", extraFruits, size);
            repo.AddBeverage(smoothie);
        }

    }
}
