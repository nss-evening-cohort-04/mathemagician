using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagicianTests.Numbers
{
        [TestClass]
        public class PrimeNumberTests
        {
            //Recursive Definition of Prime
            //F3 = F2 + F1;
            //F7 = F6 + F5;
            [TestMethod]
            public void EnsureICanCreateInstance()
            {
                PrimeNumber primeNumber = new PrimeNumber();
                Assert.IsNotNull(primeNumber);
            }

            [TestMethod]
            public void EnsureTwoIsTheFirst()
            {

                //Arrange (where you set stuff up)
                PrimeNumber primeNumber = new PrimeNumber();

                //Act (call the method you're testing)
                //test only one method at a time
                int expectedResult = 2;
                int actualResult = primeNumber.GetFirst();

                //Assert (check the output from your method)
                Assert.AreEqual(actualResult, expectedResult);
            }

            [TestMethod]
            public void EnsureICanGetNext()
            {
                // Arrange
                PrimeNumber primeNumber = new PrimeNumber();

                // Act
                int expectedResult = 13;
                //int myNum; this is zero "0"
                int actualResult = primeNumber.GetNext(5);

                // Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [TestMethod]
            public void EnsureICanGetSequence()
            {
                // Arrange
                PrimeNumber primeNumber = new PrimeNumber();

                // Act
                int[] expectedResult = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
                //int myNum; this is zero "0"
                int[] actualResult = primeNumber.GetSequence(10);

                // Assert
                Assert.AreEqual(expectedResult.Length, actualResult.Length);
                CollectionAssert.AreEqual(expectedResult, actualResult);
            }

            [TestMethod]
            public void EnsureICanPrintSequence()
            {
                //Arrange (where you set stuff up)
                PrimeNumber primeNumber = new PrimeNumber();

                //Act (call the method you're testing)
                string expectedResult = "1 1 2 3 5";
                int[] inputArray = new[] { 1, 1, 2, 3, 5 };
                string actualResult = primeNumber.PrintNumbers(inputArray);


                //Assert (check the output from your method)
                Assert.AreEqual(expectedResult, actualResult);

            }
       }
}
