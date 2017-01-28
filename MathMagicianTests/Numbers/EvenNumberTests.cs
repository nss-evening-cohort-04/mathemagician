using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureFirstEven()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call the method you're testing)
            int expectedResult = 2;
            int actualResult =  evenNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFollowingEven()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureEvenSequence()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act 
            int[] actualResult = evenNumber.GetSequence(5);
            int[] expectedResult = new int[] { 2, 4, 6, 8, 10 };

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
