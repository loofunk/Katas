using Katas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class OddEven : IOddEven
    {
        public bool IsOddNumber(int input)
        {
            return input % 2 > 0;
        }

        public bool IsEvenNumber(int input)
        {
            return input % 2 == 0;
        }
    }
}
