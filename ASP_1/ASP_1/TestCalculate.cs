using NUnit.Framework;

namespace ASP2
{
    //Class that carries out NUnit Tests on Function.cs
    [TestFixture]
    public class TestCalculate
    {
        [TestCase]
        public void testAdd()
        {
            ASP_1.Calculate f = new ASP_1.Calculate();
            Assert.AreEqual(f.add(5, 5), 10);
            Assert.AreEqual(f.add(-5, -3), - 8);
            Assert.AreNotEqual(f.add(2, 2), 2);
        }
        [TestCase]
        public void testSubtract()
        {
            ASP_1.Calculate f = new ASP_1.Calculate();
            Assert.AreEqual(f.subtract(5, 5), 0);
            Assert.AreEqual(f.subtract(-5, -3), -2);
            Assert.AreNotEqual(f.subtract(2, 2), 2);
        }
        [TestCase]
        public void testMultiply()
        {
            ASP_1.Calculate f = new ASP_1.Calculate();
            Assert.AreEqual(f.multiply(5, 5), 25);
            Assert.AreEqual(f.multiply(-5, -3), 15);
            Assert.AreNotEqual(f.multiply(2, 2), 5);
        }

        [TestCase]
        public void testDivide()
        {
            ASP_1.Calculate f = new ASP_1.Calculate();
            Assert.AreEqual(f.divide(6, 2), 3);
            Assert.AreEqual(f.divide(-15, -3), 5);
            Assert.AreNotEqual(f.divide(2, 2), 2);
        }


    }
}