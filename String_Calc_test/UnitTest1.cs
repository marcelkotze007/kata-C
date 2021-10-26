using System;
using Xunit;
using String_Calc;

namespace String_Calc_test
{
    public class UnitTest1
    {
        [Fact]
        public void Tests_Zero()
        {
            Assert.Equal(0, Class1.Add(""));
        }

        [Fact]
        public void Tests_One()
        {
            Assert.Equal(1, Class1.Add("1"));
        }

        [Fact]
        public void Tests_Two()
        {
            Assert.Equal(3, Class1.Add("1,2"));
        }

        [Fact]
        public void Tests_Unkown()
        {
            Assert.Equal(10, Class1.Add("1,2,3,4"));
        }

        [Fact]
        public void Tests_Newline()
        {
            Assert.Equal(10, Class1.Add("1\n2,3,4"));
        }

        [Fact]
        public void Tests_User_Delim()
        {
            Assert.Equal(3, Class1.Add("//;\n1;2"));
        }
    }
}