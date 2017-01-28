using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenTests
    {
        // This is a sanity check test.
        // Ensure everthing is hooked up correctly AND
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Even even = new Even();
            Assert.IsNotNull(even);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            Even even = new Even();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = even.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextIsTheNextNumber()
        {
            // Arrange (Where you set stuff up)
            Even even = new Even();

            // Act (Call the method you're testing)
            int expectedResult = 4 + 2;
            int actualResult = even.GetNext(4);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumsAreRequestedNums()
        {
            // Arrange (Where you set stuff up)
            Even even = new Even();

            // Act (Call the method you're testing)
            int[] expectedResult = new int[] { 2, 4, 6 };
            int[] actualResult = even.GetSequence(3);

            // Assert (Check the output from your method)
            CollectionAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersWork()
        {
            // Arrange (Where you set stuff up)
            Even even = new Even();

            // Act (Call the method you're testing)
            string expectedResult = "2 4 6";
            string actualResult = even.PrintNumbers(even.GetSequence(3));

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

