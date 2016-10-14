using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class DivideTwoIntegersTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int dividend, int divisor, int output)
        {
            Assert.Equal(output, Solution029.Divide(dividend,divisor));
        }
    }
}

