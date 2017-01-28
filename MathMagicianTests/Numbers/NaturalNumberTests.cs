using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        // This is a sanity check test - ensures everything is hooking up correctly AND
        // that the permissions are correct. 
        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (set it up - instatiate for this)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (call the method - ONE - you are testing; compare expected with actual result)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (check the method's output)
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void EnsureICanGetNext()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            // Act
            int expectedResult = 4;
            int actualResult = NaturalNumber.GetNext(3);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
