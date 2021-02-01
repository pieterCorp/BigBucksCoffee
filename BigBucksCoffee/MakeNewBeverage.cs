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
            Beer beer = new Stella(id, name, description, price, img, alcoholPercentage, isTrapist, type);
            repo.AddBeverage(beer);
        }

        public void MakeNewSoda()
        { }

        public void MakeNewSmoothie()
        { }



    }
}
