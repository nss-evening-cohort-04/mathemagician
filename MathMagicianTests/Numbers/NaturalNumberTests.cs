using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This ensures everything is hooked up
        // AND that the permissions are correct
        [TestMethod]
        public void EnsureICanCreatInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();
            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (where you call the method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
