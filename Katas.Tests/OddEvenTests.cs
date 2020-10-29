using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Tests
{
    public class OddEvenTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(1, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        public void IsValidatingOddNumbers(int input, bool expected)
        {
            // ARRANGE
            var oddeven = new OddEven();

            // ACT
            var result = oddeven.IsOddNumber(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        public void IsValidatingEvenNumbers(int input, bool expected)
        {
            // ARRANGE
            var oddeven = new OddEven();

            // ACT
            var result = oddeven.IsEvenNumber(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }   
    }
}
