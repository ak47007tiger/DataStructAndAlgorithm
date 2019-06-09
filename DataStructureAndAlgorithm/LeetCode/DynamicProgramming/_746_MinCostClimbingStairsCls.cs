using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
On a staircase, the i-th step has some non-negative cost cost[i] assigned (0 indexed).

Once you pay the cost, you can either climb one or two steps. 
You need to find minimum cost to reach the top of the floor, and you can either start from the step with index 0, or the step with index 1.

Example 1:
Input: cost = [10, 15, 20]
Output: 15
Explanation: Cheapest is start on cost[1], pay that cost and go to the top.
Example 2:
Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
Output: 6
Explanation: Cheapest is start on cost[0], and only step on 1s, skipping cost[3].
Note:
cost will have a length in the range [2, 1000].
Every cost[i] will be an integer in the range [0, 999].
 */

/*
求最优解的一般可以尝试动态规划
动态规划需要递推公式
递推公式需要递推关系
dp[n] = min(dp[n-1], dp[n-2]) + cost[n]
 */

namespace LeetCode {
  public class MinCostClimbingStairsCls {
    public int MinCostClimbingStairs(int[] cost) {
      var dps = new int[cost.Length];
      dps[0] = cost[0];
      dps[1] = cost[1];
      for(var i = 2; i < cost.Length; i++){
        dps[i] = Math.Min(dps[i - 1], dps[i - 2]) + cost[i];
      }
      return Math.Min(dps[dps.Length - 1], dps[dps.Length - 2]);
    }
  }
}