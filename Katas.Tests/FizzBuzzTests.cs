using Katas.Interfaces;
using NUnit.Framework;

namespace Katas.Tests
{
    public class FizzBuzzTests
    {
        private IFizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void ShouldReturnFizz(int input, string expected)
        {
            // ARRANGE
            var result = _fizzBuzz.GetFizzBuzz(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }


        [TestCase(30, 10, true)]
        [TestCase(10, 10, true)]
        [TestCase(20, 10, true)]
        public void IsCalculatingMultiplierInTens(int intput, int multiple, bool expected)
        {
            // ARRANGE
            var result = _fizzBuzz.IsItAMultiple(intput, multiple);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, 5, true)]
        [TestCase(10, 5, true)]
        [TestCase(20, 5, true)]
        public void IsCalculatingMultiplierInFives(int intput, int multiple, bool expected)
        {
            // ARRANGE
            var result = _fizzBuzz.IsItAMultiple(intput, multiple);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestCase(6, 6, true)]
        [TestCase(12, 6, true)]
        [TestCase(24, 6, true)]
        public void IsCalculatingMultiplierInSixes(int intput, int multiple, bool expected)
        {
            // ARRANGE
            var result = _fizzBuzz.IsItAMultiple(intput, multiple);

            // ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}