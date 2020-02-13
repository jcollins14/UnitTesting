//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xunit;

//namespace UnitTesting
//{
//   public  class OddEvenTest
//    {
//        private OddEven o = new OddEven();

//        [Fact]
//        public void OddTest()
//        {
//            string expected = "Odd";
//            string actual = o.DoOddEven(1);
//            Assert.Equal(expected,actual);
//        }
//        [Fact]
//        public void EvenTest()
//        {
//            string expected = "Even";
//            string actual = o.DoOddEven(4);
//            Assert.Equal(expected, actual);
//        }
//        [Theory]
//        [InlineData(2)]
//        [InlineData(5)]
//        [InlineData(7)]
//        [InlineData(11)]
//        public void PrimeTest(int x)
//        {
//            string expected = "Prime";
//            string actual = o.DoOddEven(x);
//            Assert.Equal(expected, actual);
//        }
//    }
//}
