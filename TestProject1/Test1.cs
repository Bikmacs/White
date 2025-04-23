namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestClass]
        public class PrimeCheckerTests
        {
            [TestMethod]
            public void Test_IsPrime_LessThanTwo()
            {
                Assert.IsFalse(PrimeChecker.IsPrime(1));
                Assert.IsFalse(PrimeChecker.IsPrime(0));
                Assert.IsFalse(PrimeChecker.IsPrime(-5));
            }

            [TestMethod]
            public void Test_IsPrime_PrimeNumbers()
            {
                Assert.IsTrue(PrimeChecker.IsPrime(2));
                Assert.IsTrue(PrimeChecker.IsPrime(3));
                Assert.IsTrue(PrimeChecker.IsPrime(5));
                Assert.IsTrue(PrimeChecker.IsPrime(7));
            }

            [TestMethod]
            public void Test_IsPrime_NonPrimeNumbers()
            {
                Assert.IsFalse(PrimeChecker.IsPrime(4));
                Assert.IsFalse(PrimeChecker.IsPrime(6));
                Assert.IsFalse(PrimeChecker.IsPrime(8));
                Assert.IsFalse(PrimeChecker.IsPrime(9));
            }

            [TestMethod]
            public void Test_IsPrime_LargePrimeNumber()
            {
                Assert.IsTrue(PrimeChecker.IsPrime(29));
            }

            [TestMethod]
            public void Test_IsPrime_LargeNonPrimeNumber()
            {
                Assert.IsFalse(PrimeChecker.IsPrime(100));
            }
        }
    }
    
}
