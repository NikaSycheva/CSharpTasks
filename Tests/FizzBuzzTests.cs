using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class FizzBuzzTests
    {
        [Test]
        public void LetsFizzBuzz_0_3_5_15_22_100_555()
        {
            var fb = new FizzBuzz();
            var sequence = new List<int>() { 0, 3, 5, 15, 22, 100, 555 };
            var expectedResult = new List<string>() {"FizzBuzz", "Fizz", "Buzz", 
                                                     "FizzBuzz", "22","Buzz", "FizzBuzz"};
            var actualResult = fb.LetsFizzBuzz(sequence);
            
            Assert.That(actualResult, Is.EqualTo(expectedResult));            
        }
    }
}
