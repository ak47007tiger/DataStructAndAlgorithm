using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given an array nums of integers, you can perform operations on the array.

In each operation, you pick any nums[i] and delete it to earn nums[i] points. After, 
you must delete every element equal to nums[i] - 1 or nums[i] + 1.

You start with 0 points. Return the maximum number of points you can earn by applying such operations.

Example 1:
Input: nums = [3, 4, 2]
Output: 6
Explanation: 
Delete 4 to earn 4 points, consequently 3 is also deleted.
Then, delete 2 to earn 2 points. 6 total points are earned.
Example 2:
Input: nums = [2, 2, 3, 3, 3, 4]
Output: 9
Explanation: 
Delete 3 to earn 3 points, deleting both 2's and the 4.
Then, delete 3 again to earn 3 points, and 3 again to earn 3 points.
9 total points are earned.
Note:

The length of nums is at most 20000.
Each element nums[i] is an integer in the range [1, 10000].
 */
/*
尽量少删除
删除就是置0
dp[i]表示pick nums[i]得到的最大的点数
dp[i] = dp[j] + nums[i]
 */
namespace LeetCode.Medium {
  public class DeleteAndEarnCls {
    public int DeleteAndEarn(int[] nums) {
      var max = int.MinValue;
      var dp = new int[nums.Length];
      dp[0] = nums[0];
      for(var i = 0; i < nums.Length; i++){
        
      }
      return max;
    }
  }
}