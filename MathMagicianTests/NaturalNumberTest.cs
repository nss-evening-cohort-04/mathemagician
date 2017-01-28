using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;
using System.Diagnostics;

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
        public void EnsureNumberOneFirstNumber()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int result = 1;
            int actualresult = naturalNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(result, actualresult);
        }

        [TestMethod]
        public void EnsureNumberPlusOneNumber()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int expectedresult = 2;
            int actualresult = naturalNumber.GetNext(1);

            //Assert (check the output from your method)
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void EnsureNumberSequence()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int expectedresult = ("1", "2", "3", "4", 5, 6, 7, 8, 9, 10);
            int actualresult = naturalNumber.GetNext(1);

            //Assert (check the output from your method)
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
