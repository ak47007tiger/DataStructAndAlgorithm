using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  /*
You are climbing a stair case. It takes n steps to reach to the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Note: Given n will be a positive integer.

Example 1:

Input: 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
   */
  public class ClimbStairs {
    public int Solution3(int n) {
      if(n == 1) return 1;
      if(n == 2) return 2;

      var nm2 = 1;
      var nm1 = 2;
      var nm0 = 0;
      for(var i = 3; i <= n; i++){
        nm0 = nm1 + nm2;
        nm2 = nm1;
        nm1 = nm0;
      }
      return nm0;
    }

    public int Solution2(int n) {
      if(n == 1) return 1;
      if(n == 2) return 2;

      var results = new int[n];
      results[0] = 1;
      results[1] = 2;
      for(var i = 2; i < n; i++){
        results[i] = results[i - 1] + results[i - 2];
      }
      return results[n - 1];
    }

    public int Solution1(int n) {
      if(n == 1) return 1;
      if(n == 2) return 2;
      if(n == 3) return 3;
      return Solution1(n - 1) + Solution1(n - 2);
    }
  }
}