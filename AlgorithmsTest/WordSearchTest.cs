using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class WordSearchTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(char[,] board, string word, bool output)
        {
            Assert.Equal(output, Solution079.Exist(board, word));
        }
    }
}

