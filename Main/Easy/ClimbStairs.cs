using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class ClimbStairs {
    public int Compute(int n) {
      var sum = 0;
      for (var i = 0; i <= n; i++) {
        if ((n - i) % 2 == 0) {
          sum++;
        }
      }
      return sum;
    }
  }
}