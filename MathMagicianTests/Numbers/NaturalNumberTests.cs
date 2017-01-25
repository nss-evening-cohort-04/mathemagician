using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity check test.
        // Ensures everything is hooked correctly and 
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturelNumber = new NaturalNumber();

            Assert.IsNotNull(naturelNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
