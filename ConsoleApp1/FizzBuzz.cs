using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FizzBuzz
    {
        public List<string> LetsFizzBuzz(List<int> inputSequence)
        {
            var list = new List<string>();

            foreach (var item in inputSequence)
            {
                if (item % 3 == 0 && item % 5 == 0)
                    list.Add("FizzBuzz");
                else if (item % 3 == 0)
                    list.Add("Fizz");
                else if (item % 5 == 0)
                    list.Add("Buzz");
                else
                    list.Add(item.ToString());
            }
            return list;
        }
    }
}
