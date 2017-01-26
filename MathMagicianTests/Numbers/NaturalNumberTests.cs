using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity check test.
        // Ensure everthing is hooked up correctly AND
        // that the permissions are correct.
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
        public void EnsureNextIsTheNextNumber()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int expectedResult = 3 + 1;
            int actualResult = naturalNumber.GetNext(3);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumsAreRequestedNums()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = new int[] { 1, 2, 3 };
            int[] actualResult = naturalNumber.GetSequence(3);

            // Assert (Check the output from your method)
            CollectionAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersWork()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            string expectedResult = "1 2 3";
            string actualResult = naturalNumber.PrintNumbers(naturalNumber.GetSequence(3));

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
