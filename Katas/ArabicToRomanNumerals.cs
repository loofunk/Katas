using Katas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class ArabicToRomanNumerals : IArabicToRomanNumerals
    {
        private readonly Dictionary<int, string> _dictionary;
        private readonly StringBuilder _stringBuilder;
        private int _number;

        public ArabicToRomanNumerals(int number)
        {
            _dictionary = new Dictionary<int, string>
            {
                {1,"I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {10, "X"}
            };

            _stringBuilder = new StringBuilder();
            _number = number;
        }

        private void ProcessArabic(int limiter)
        {
            while (_number >= limiter)
            {
                _stringBuilder.Append(_dictionary[limiter]);
                _number -= limiter;
            }
        }

        public string ParseRoman()
        {
            ProcessArabic(10);
            ProcessArabic(9);
            ProcessArabic(5);
            ProcessArabic(4);
            ProcessArabic(1);

            return _stringBuilder.ToString();
        }
    }
}
