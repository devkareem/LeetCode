// Source : https://leetcode.com/problems/subsets/ 
// Author : codeyu 
// Date : Tuesday, January 24, 2017 11:56:48 PM 

/**********************************************************************************
*
* 
* Given a set of distinct integers, nums, return all possible subsets.
* 
* Note: The solution set must not contain duplicate subsets.
* 
* 
* For example,
* If nums = [1,2,3], a solution is:
* 
* 
* 
* [
*   [3],
*   [1],
*   [2],
*   [1,2,3],
*   [1,3],
*   [2,3],
*   [1,2],
*   []
* ]
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution078 
    {
        public static IList<IList<int>> Subsets(int[] nums) 
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length == 0) {
                return result;
            }

            IList<int> list = new List<int>();
            Utils.Helper.Sort(nums);
            backTrack(result, list, nums, 0);
            return result;
        }
        private static void  backTrack(IList<IList<int>> result,
            IList<int> list, int[] num, int pos) 
        {
            result.Add(list);

            for (int i = pos; i < num.Length; i++) {
                list.Add(num[i]);
                backTrack(result, list, num, i + 1);
                list.Remove(list.Count - 1);
            }
        }
    }
}

