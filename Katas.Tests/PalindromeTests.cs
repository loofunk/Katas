using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Tests
{
    public class PalindromeTests
    {
        [TestCase("Anna")]
        [TestCase("Ana")]
        public void ShouldReturnIsAPalindrome(string word)
        {
            // ARRANGE
            var palindrome = new Palindrome();

            // ACT
            var result = palindrome.IsPalindrome(word.ToLower());

            //  ASSERT
            Assert.AreEqual(true, result); 
        }

        [TestCase("Anna")]
        public void ShouldReverseText(string word)
        {
            // ARRANGE
            var palindrome = new Palindrome();

            // ACT
            var reversed = palindrome.ReverseString(word);

            // ASSERT
            Assert.AreEqual(reversed, word.ToLower());
        }
    }
}
