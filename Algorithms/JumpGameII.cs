// Source : https://leetcode.com/problems/jump-game-ii/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:19:31 PM 

/**********************************************************************************
*
* 
* Given an array of non-negative integers, you are initially positioned at the first index of the array.
* 
* 
* Each element in the array represents your maximum jump length at that position. 
* 
* 
* Your goal is to reach the last index in the minimum number of jumps.
* 
* 
* 
* For example:
* Given array A = [2,3,1,1,4]
* 
* 
* The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)
* 
* 
* 
* Note:
* You can assume that you can always reach the last index.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution045 
    {
        public static int Jump(int[] nums) 
        {
            if(nums==null || nums.Length==0) return 0;  
            int lastReach = 0;  
            int reach = 0;  
            int step = 0;  
            for(int i=0;i<=reach&&i<nums.Length;i++)  
            {  
                if(i > lastReach)  
                {  
                    step++;  
                    lastReach = reach;  
                }  
                reach = Math.Max(reach, nums[i]+i);  
            }  
            if(reach<nums.Length-1) return 0;  
            return step;
            
        }
    }
}

