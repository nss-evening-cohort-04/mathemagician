﻿using System;
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
            int current = 4;

            //Act
            int expectedResult = 5;
            int actualResult = naturalNumber.GetNext(current);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


    }
}
