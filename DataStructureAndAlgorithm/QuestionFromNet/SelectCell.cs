using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

/*
有n个格子，不能选相邻的格子，请问有多少种选法？
note:
什么也不选也是一种选法
 */

/*
暴力解法处理后发现，是斐波那契数列
 */
namespace LeetCode.Hard {

  public class SelectCell : BaseSolution {

    public int SelectCount(int n){
      if(n <= 0) return 1;
      if(n == 1) return 2;
      if(n == 2) return 3;
      var sum = 1;
      for(var i = 0; i < n; i++){
        sum += SelectCount(n - i - 2);
      }
      return sum;
    }


  }

}
