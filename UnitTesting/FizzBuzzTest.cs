using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class FizzBuzzTest
    {
        private FizzBuzz fb = new FizzBuzz();
        [Fact]
        public void TestFizz()
        {
            string expected = "Fizz";
            string actual = fb.DoFizzBuzz(3);
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void TestBuzz()
        {
            string expected = "Buzz";
            string actual = fb.DoFizzBuzz(5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFizzBuzz()
        {
            string expected = "FizzBuzz";
            string actual = fb.DoFizzBuzz(15);
            Assert.Equal(expected, actual);
        }
    }
}
