using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void OneReturnsOne()
        {
            Assert.AreEqual("1", new Game().Play(1));
        }

        [TestMethod]
        public void TwoReturnsTwo()
        {
            Assert.AreEqual("2", new Game().Play(2));
        }

        [TestMethod]
        public void ThreeReturnsFizz()
        {
            Assert.AreEqual("Fizz", new Game().Play(3));
        }

        [TestMethod]
        public void FiveReturnsBuzz()
        {
            Assert.AreEqual("Buzz", new Game().Play(5));
        }

        [TestMethod]
        public void FifteenReturnsFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", new Game().Play(15));
        }
    }
}
