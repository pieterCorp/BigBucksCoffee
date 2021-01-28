using System.Collections.Generic;

namespace BigBucksCoffee
{
    internal interface IBeverageRepo
    {
        List<IBeverage> GetBeverages();

        IBeverage GetBeverage(int id);
    }
}