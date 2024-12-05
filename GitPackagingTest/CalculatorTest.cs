using GitPackaging;

namespace GitPackagingTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator calculator = new();
            Assert.AreEqual(3, calculator.Add(1, 2));
        }
    }
}