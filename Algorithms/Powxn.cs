// Source : https://leetcode.com/problems/powx-n/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:21:24 PM 

/**********************************************************************************
*
* Implement pow(x, n).
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution050 
    {
        public static double MyPow(double x, int n) 
        {
            if(n == 0) return 1.0;
            var ans = 1.0;
            var i = Math.Abs(n);
            while( i > 0)
            {
                ans *= x;
                i--;
            }
            return n > 0 ? ans : 1.0 / ans;
        }

        public static double MyPow2(double x, int n)
        {
            if(n == 0) return 1.0;
            var ans = 1.0;
            if(n<0)  
            {  
                if(x >= 1.0/Double.MaxValue || x <= 1.0/-Double.MaxValue)  
                    x = 1.0/x;  
                else  
                    return Double.MaxValue;  
                if(n==int.MinValue)  
                {  
                    ans *= x;  
                    n++;  
                }  
            }
            n = Math.Abs(n);
            bool isNeg = false;  
            if(n % 2 == 1 && x < 0)  
            {  
                isNeg = true;  
            }
            x = Math.Abs(x);  
            while(n > 0)
            {  
                if((n & 1) == 1)
                {  
                    if(ans > Double.MaxValue / x) return Double.MaxValue;
                    ans = ans * x;   
                }  
                x = x * x;  
                n >>= 1;  //快速幂 
            }
            return isNeg ? -ans : ans;
        }
    }
}

