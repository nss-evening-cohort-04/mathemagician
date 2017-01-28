using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity check test.
        // Ensures everything is hooked up correctly AND that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumberInSequenceIsNatural()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int expectedResult = 13;
            int actualResult = naturalNumber.GetNext(12);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = { 1, 2, 3, 4, 5 };
            int[] actualResult = naturalNumber.GetSequence(5);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            string expectedResult = "1, 2, 3, 4, 5";
            string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
