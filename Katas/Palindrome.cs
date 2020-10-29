using Katas.Interfaces;
using System;

namespace Katas
{
    public class Palindrome : IPalindrome
    {
        public bool IsPalindrome(string text)
        {
            var lowerCaseText = text.ToLower();
            return string.Equals(ReverseString(lowerCaseText), lowerCaseText);
        }

        public string ReverseString(string text)
        {
            var textArray = text.ToLower().ToCharArray();

            Array.Reverse(textArray);

            return new string(textArray);
        }
    }
}
