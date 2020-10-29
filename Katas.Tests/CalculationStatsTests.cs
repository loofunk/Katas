using Katas.Interfaces;
using NUnit.Framework;

namespace Katas.Tests
{
    public class CalculationStatsTests
    {
        private ICalculationStats _calcStats;

        [SetUp]
        public void Setup()
        {
            _calcStats = new CalcStats();
        }

        [Test]
        public void ShouldReturnMinimumValue()
        {
            // ARRANGE
            var items = new int[] { 6, 9, 15, -2, 92, 11 };

            // ACT
            var result = _calcStats.GetMinValue(items);

            // ASSERT
            Assert.AreEqual(-2, result);
        }


        [Test]
        public void ShouldReturnMaxiumumValue()
        {
            // ARRANGE
            var items = new int[] { 6, 9, 15, -2, 92, 11 };

            // ACT
            var result = _calcStats.GetMaxValue(items);

            // ASSERT
            Assert.AreEqual(92, result);
        }

        [Test]
        public void ShouldReturnCorrectNumberOfElementsInSequence()
        {
            // ARRANGE
            var items = new int[] { 6, 9, 15, -2, 92, 11 };

            // ACT
            var result = _calcStats.Count(items);

            // ASSERT
            Assert.AreEqual(6, result);
        }

    }
}
