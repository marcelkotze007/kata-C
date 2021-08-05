using System;
using Xunit;
using String_Calc;

namespace String_Calc_test
{
    public class UnitTest1
    {
        [Fact]
        public void test_empty()
        {
            Assert.Equal(0, Class1.Add(""));
        }
    }
}
