﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        //this is a sanity check test
        //Ensures everything is hooked up correctly and
        //that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);

        }
    }
}
