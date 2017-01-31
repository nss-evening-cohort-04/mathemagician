
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        
        [TestMethod]
        public void EnsureICanCreateInstanceOdd()
        {
            OddNumber oddNumber = new OddNumber();
            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void EnsureICanGetTheNextNumberOdd()
        {
            // Arrange 
            OddNumber oddNumber = new OddNumber();

            // Act 
            int expectedResult = 5;
            int actualResult = oddNumber.GetNext(3);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
      

        }

       
    }
