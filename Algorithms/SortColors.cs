// Source : https://leetcode.com/problems/sort-colors 
// Author : codeyu 
// Date : Sunday, January 15, 2017 11:23:01 PM 

/**********************************************************************************
*
* 
* Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.
* 
* 
* 
* Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
* 
* 
* 
* Note:
* You are not suppose to use the library's sort function for this problem.
* 
* 
* click to show follow up.
* 
* 
* Follow up:
* A rather straight forward solution is a two-pass algorithm using counting sort.
* First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
* Could you come up with an one-pass algorithm using only constant space?
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution075
    {
        public static void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            int[] res = new int[nums.Length];
            int[] helper = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                helper[nums[i]]++;
            }
            for (int i = 1; i < 3; i++)
            {
                helper[i] = helper[i] + helper[i - 1];
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[helper[nums[i]] - 1] = nums[i];
                helper[nums[i]]--;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = res[i];
            }
        }
    }
}

