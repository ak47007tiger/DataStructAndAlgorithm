using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStruct;

/*
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, 
the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police 
if two adjacent houses were broken into on the same night.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.

Example 1:

Input: [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
             Total amount you can rob = 1 + 3 = 4.
Example 2:

Input: [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
             Total amount you can rob = 2 + 9 + 1 = 12.
 */

/*
审题
一个数组，从index = 0


[2,1,1,2]
4

递归解法超时

看了网上参考获知递推方程

复习
递推公式
dp[i] = math.max(dp[i- 1],num[i] + dp[i - 2])
 */
namespace LeetCode.Easy {

  public class HouseRobber : BaseSolution {
    public int Rob(int[] nums) {
      if(nums == null || nums.Length == 0) return 0;

      if(nums.Length == 1) return nums[0];

      var dp = new int[nums.Length];
      dp[0] = nums[0];
      dp[1] = Math.Max(nums[0], nums[1]);
      var max = dp[1];
      for(var i = 2; i < nums.Length; i++){
        dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
        max = Math.Max(max, dp[i]);
      }
      return max;
    }

    public int Rob1(int[] nums) {
      var max = 0;
      for (var i = 0; i < nums.Length; i++) {
        max = Math.Max(max, GetMax(nums, i));
      }
      return max;
    }

    int GetMax(int[] nums, int start) {
      if (start >= nums.Length)return 0;

      var max = 0;
      for (var i = 2; i < nums.Length; i++) {
        max = Math.Max(max, GetMax(nums, start + i));
      }

      return nums[start] + max;
    }

  }

}