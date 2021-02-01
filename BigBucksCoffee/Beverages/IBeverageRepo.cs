using System.Collections.Generic;

namespace BigBucksCoffee
{
    internal interface IBeverageRepo
    {
        void AddBeverage(IBeverage beverage);
        IBeverage GetBeverage(int id);
        IList<IBeverage> GetBeverages();
    }
}