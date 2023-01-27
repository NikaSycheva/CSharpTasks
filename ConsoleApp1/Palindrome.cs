using System;
using System.Collections.Generic;
using System.Text;

namespace SharpLearning
{
    public class Palindrome
    {
        public bool IsPalindrome(int number)
        {
            var stringNumber = number.ToString();            
            char[] arr = stringNumber.ToCharArray();
            Array.Reverse(arr);            
            var resultString = new string(arr);
            return stringNumber == resultString;
        }

        public bool IsPalindrome2(int number)
        {
            var tmp = number;
            int result = 0;
            if (number < 0)
                return false;
            else 
            {
                while (tmp != 0)
                {
                    int l = tmp % 10;
                    result = result * 10 + l;
                    tmp /= 10;
                }
                return number == result;
            }            
        }
    }
}
