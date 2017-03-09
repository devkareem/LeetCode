using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidateBinarySearchTreeTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(TreeNode root, bool output)
        {
            Assert.Equal(output, Solution098.IsValidBST(root));
        }
    }
}

