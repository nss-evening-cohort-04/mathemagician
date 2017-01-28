using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;


namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureICanGetFirstEvenNumber()
        {
            // Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNextEvenNumber()
        {
            // Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequenceOfEvenNumbers()
        {
            // Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequenceOfEvenNumbers()
        {
            // Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            string expectedResult = "2 4 6 8 10";
            string actualResult = evenNumber.PrintNumbers(new[] { 2, 4, 6, 8, 10 });

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
