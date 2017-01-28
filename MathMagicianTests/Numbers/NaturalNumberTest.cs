using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();
            Assert.IsNotNull(naturalNumber);
        }


        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {

            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act(call the method you're testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert(Check the output for your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnsureNextCurrent(int current)
        {
            //Arrange
            NaturalNumber currentNumber = new NaturalNumber();
            //Act
            int expectedResult = 2;
            int actualResult = currentNumber.GetNext();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }

    }
}
