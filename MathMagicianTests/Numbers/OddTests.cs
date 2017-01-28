using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddTests
    {
        // This is a sanity check test.
        // Ensure everthing is hooked up correctly AND
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Odd odd = new Odd();
            Assert.IsNotNull(odd);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            Odd odd = new Odd();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = odd.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextIsTheNextNumber()
        {
            // Arrange (Where you set stuff up)
            Odd odd = new Odd();

            // Act (Call the method you're testing)
            int expectedResult = 3 + 2;
            int actualResult = odd.GetNext(3);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumsAreRequestedNums()
        {
            // Arrange (Where you set stuff up)
            Odd odd = new Odd();

            // Act (Call the method you're testing)
            int[] expectedResult = new int[] { 1, 3, 5 };
            int[] actualResult = odd.GetSequence(3);

            // Assert (Check the output from your method)
            CollectionAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersWork()
        {
            // Arrange (Where you set stuff up)
            Odd odd = new Odd();

            // Act (Call the method you're testing)
            string expectedResult = "1 3 5";
            string actualResult = odd.PrintNumbers(odd.GetSequence(3));

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
