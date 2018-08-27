using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class Solutions_11_20 {

    public int MySqrt(int x) {
      return (int)Math.Sqrt(x);
    }

    public int MySqrt1(int x) {
      return (int)Math.Sqrt(x);
    }

    /**
    1 * a + 2 * b == n
    求 a, b的组合数量
    a: [0,n]
     */
    public int ClimbStairs(int n) {
      var sum = 0;
      for(var i = 0; i <= n; i++){
        if((n - i) % 2 == 0){
          sum++;
        }
      }
      return sum;
    }
  }
}