namespace TestProject2
{
    [TestClass]
    public class PrimeCheckerTests
    {
        [TestMethod]
        public void Test_IsPrime_LessThanTwo()
        {
            // Тест для чисел меньше двух
            Assert.IsFalse(PrimeChecker.IsPrime(1));
            Assert.IsFalse(PrimeChecker.IsPrime(0));
            Assert.IsFalse(PrimeChecker.IsPrime(-5));
        }

        [TestMethod]
        public void Test_IsPrime_PrimeNumbers()
        {
            // Тест для простых чисел
            Assert.IsTrue(PrimeChecker.IsPrime(2));
            Assert.IsTrue(PrimeChecker.IsPrime(3));
            Assert.IsTrue(PrimeChecker.IsPrime(5));
            Assert.IsTrue(PrimeChecker.IsPrime(7));
        }

        [TestMethod]
        public void Test_IsPrime_NonPrimeNumbers()
        {
            // Тест для непростых чисел
            Assert.IsFalse(PrimeChecker.IsPrime(4));
            Assert.IsFalse(PrimeChecker.IsPrime(6));
            Assert.IsFalse(PrimeChecker.IsPrime(8));
            Assert.IsFalse(PrimeChecker.IsPrime(9));
        }

        [TestMethod]
        public void Test_IsPrime_LargePrimeNumber()
        {
            // Тест для больших простых чисел
            Assert.IsTrue(PrimeChecker.IsPrime(29));
            Assert.IsTrue(PrimeChecker.IsPrime(53));
        }

        [TestMethod]
        public void Test_IsPrime_LargeNonPrimeNumber()
        {
            // Тест для больших непростых чисел
            Assert.IsFalse(PrimeChecker.IsPrime(100));
            Assert.IsFalse(PrimeChecker.IsPrime(200));
        }

        [TestMethod]
        public void Test_IsPrime_BoundaryValues()
        {
            // Тест для граничных значений
            Assert.IsFalse(PrimeChecker.IsPrime(-1));
            Assert.IsFalse(PrimeChecker.IsPrime(0));
            Assert.IsFalse(PrimeChecker.IsPrime(1));
        }
    }
}
