using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        //This is a "sanity check" test.
        //Ensures everything is hooked up correctly AND that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            //Arrange (set up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call method being tested)
            int exepectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (check output from method)
            Assert.AreEqual(exepectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanGetNextNumber()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int expectedResult = 5;
            int actualResult = naturalNumber.GetNext(4);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanCreateSequence()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();



            //Act
            int[] expectedResult = { 1, 2, 3, 4, 5};
            int[] actualResult = naturalNumber.GetSequence(5);

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Act
            NaturalNumber naturalNumber = new NaturalNumber();

            //Arrange
            string expectedResult = "1 2 3 4 5";
            string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
