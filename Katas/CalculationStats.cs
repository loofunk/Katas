using Katas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class CalcStats : ICalculationStats
    {
        public int GetMinValue(int[] items)
        {
            return items.Select(x => x).Min();
        }

        public int GetMaxValue(int[] items)
        {
            return items.Select(x => x).Max();
        }

        public int Count(int[] items)
        {
            return items.Count();
        }

        public decimal GetAverageValue(int[] items)
        {
            decimal calculation = 0;

            foreach (var value in items)
            {
                calculation += value;
            }

            return calculation / Count(items);
        }
    }
}
