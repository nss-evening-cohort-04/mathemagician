using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateOddInstance()
        {
            OddNumber oddNumber = new OddNumber();
        }

        [TestMethod]
        public void EnsureICanGetFirstOddNumber()
        {
            OddNumber oddNumber = new OddNumber();

            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNextOddNumber()
        {
            OddNumber oddNumber = new OddNumber();

            int expectedResult = 3;
            int actualResult = oddNumber.GetNext(1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetOddSequence()
        {
            OddNumber oddNumber = new OddNumber();

            int[] expectedResult = { 1, 3, 5, 7, 9 };
            int[] actualResult = oddNumber.GetSequence(5);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintOddNumbers()
        {
            OddNumber oddNumber = new OddNumber();

            string expectedResult = "1 3 5";
            string actualResult = oddNumber.PrintNumbers(new[] { 1, 3, 5 });

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
