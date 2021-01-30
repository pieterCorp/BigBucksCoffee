using BigBucksCoffee;
using NUnit.Framework;

namespace NUnitTestProject2
{
    public class Tests
    {
        

        [SetUp]
        public void TestCalcBtw()
        {
            Cart c1 = new Cart();
            double res = c1.CalcBtw(1);
            Assert.AreEqual(res, 1,21);
        }

        [Test]
        public void TestAddToCart()
        {
            Cart c2 = new Cart();
            
        }
    }
}