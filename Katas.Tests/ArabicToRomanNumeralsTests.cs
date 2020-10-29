using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Tests
{
    public class ArabicToRomanNumeralsTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        public void ShouldConvertArabicToRoman(int input, string expected)
        {
            // ARRANGE
            var arabicToRomanNumerals = new ArabicToRomanNumerals(input);

            // ACT
            var result = arabicToRomanNumerals.ParseRoman();

            // ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}
