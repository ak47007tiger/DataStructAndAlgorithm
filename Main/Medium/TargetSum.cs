using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
You are given a list of non-negative integers, a1, a2, ..., an, and a target, S. 
Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.

Find out how many ways to assign symbols to make sum of integers equal to target S.

Example 1:
Input: nums is [1, 1, 1, 1, 1], S is 3. 
Output: 5
Explanation: 

-1+1+1+1+1 = 3
+1-1+1+1+1 = 3
+1+1-1+1+1 = 3
+1+1+1-1+1 = 3
+1+1+1+1-1 = 3

There are 5 ways to assign symbols to make the sum of nums be target 3.
Note:
The length of the given array is positive and will not exceed 20.
The sum of elements in the given array will not exceed 1000.
Your output answer is guaranteed to be fitted in a 32-bit integer.
 */

/*
nums里面的数进行添加符号，然后求和获得一个值S
问有多少种可能的组合

所有的数都要用上
只是符号不同
 */

namespace LeetCode.Main.Easy {
  public class TargetSum {

    public int FindTargetSumWays(int[] nums, int S) {
      return 0;
    }

  }
}