using NUnit.Framework;
using SharpLearning;

namespace Tests
{
    public class PalindromeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]        
        public void IsPalindrome_NumberIsPalindrome()
        {
            var pal = new Palindrome();
            var result = pal.IsPalindrome(5665);           
            Assert.IsTrue(result, "Палиндром не палиндром");
        }

        [Test]
        public void IsPalindrome_NumberIsNotPalindrome()
        {
            var pal = new Palindrome();
            var result = pal.IsPalindrome(123);
            Assert.IsFalse(result, "Не палиндром оказался палиндромом");
        }

        [Test]
        public void IsPalindrome_MinusNumberPalindrome()
        {
            var pal = new Palindrome();
            var result = pal.IsPalindrome(-121);
            Assert.IsFalse(result, "Не палиндром оказался палиндромом");
        }

        public void IsPalindrome2_NumberIsPalindrome()
        {
            var pal = new Palindrome();
            var result = pal.IsPalindrome2(5665);
            Assert.IsTrue(result, "Палиндром не палиндром");
        }

        [Test]
        public void IsPalindrome2_NumberIsNotPalindrome()
        {
            var pal = new Palindrome();
            var result = pal.IsPalindrome2(123);
            Assert.IsFalse(result, "Не палиндром оказался палиндромом");
        }

        [Test]
        public void IsPalindrome2_MinusNumberPalindrome()
        {
            var pal = new Palindrome();
            var result = pal.IsPalindrome2(-121);
            Assert.IsFalse(result, "Не палиндром оказался палиндромом");
        }

    }
}