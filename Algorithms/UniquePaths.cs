// Source : https://leetcode.com/problems/unique-paths/ 
// Author : codeyu 
// Date : Sunday, December 11, 2016 4:10:39 PM 

/**********************************************************************************
*
* A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
* 
* The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
* 
* How many possible unique paths are there?
* 
* 
* 
* Above is a 3 x 7 grid. How many possible unique paths are there?
* 
* 
* Note: m and n will be at most 100.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution062
    {
        public static int UniquePaths(int m, int n)
        {
            if(m<=0 || n<=0)
                return 0;
            int[] res = new int[n];
            res[0] = 1;
            for(int i=0;i<m;i++)
            {
                for(int j=1;j<n;j++)
                {
                res[j] += res[j-1];
                }
            }
            return res[n-1];

        }
    }
}

