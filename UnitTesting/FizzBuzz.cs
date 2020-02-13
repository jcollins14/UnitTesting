using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class FizzBuzz
    {
        public string DoFizzBuzz(int cycle)
        {
            string answer = "";

            if (cycle % 3 == 0)
            {
                answer += "Fizz";
            }
            if (cycle % 5 == 0)
            {
                answer += "Buzz";
            }
            return answer;
        }
    }
}
