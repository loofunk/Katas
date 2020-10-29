using Katas.Interfaces;
using System;

namespace Katas
{
    public class FizzBuzz : IFizzBuzz
    {
        public string GetFizzBuzz(int input)
        {
            var isFizz = input % 3 == 0;
            var isBuzz = input % 5 == 0;

            if (isFizz && isBuzz)
                return "FizzBuzz";

            if (isFizz)
                return "Fizz";

            if (isBuzz)
                return "Buzz";

            return "";
        }            

        public bool IsItAMultiple(int input, int multiple)
        {
            return input % multiple == 0;
        }
    }
}
