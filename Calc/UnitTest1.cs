using Practic;

namespace Calc
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCalculation1_Positive()
        {
            Calculation1 calc = new Calculation1(6, 7, 8);
            int result = calc.Calculate();
            Assert.AreEqual(9261, result);
        }

        [Test]
        public void TestCalculation1_Negative()
        {
            Calculation1 calc = new Calculation1(3, 2, 4);
            int result = calc.Calculate();
            Assert.AreEqual(9, result);
        }

        [Test]
        public void TestCalculation2()
        {
            Calculation2 calc = new Calculation2(10, 20);
            int result = calc.Calculate();
            Assert.AreEqual(2244, result);
        }
    }
}