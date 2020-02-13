using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class PasswordVerifyTest
    {
        private PasswordVerify verify = new PasswordVerify();
        [Fact]
        public void EightCharTest()
        {
            string expected = "Valid";
            string actual = verify.Verify("Australia14");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NullTest()
        {
            string expected = "Invalid";
            string actual = verify.Verify("");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UpperCheckTest()
        {
            string expected = "Valid";
            string actual = verify.Verify("Australia14");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LowerCheckTest()
        {
            string expected = "Valid";
            string actual = verify.Verify("Australia14");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumCheckTest()
        {
            string expected = "Valid";
            string actual = verify.Verify("Australia14");
            Assert.Equal(expected, actual);
        }


    }
}
