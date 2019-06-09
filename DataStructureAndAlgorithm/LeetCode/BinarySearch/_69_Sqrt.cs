using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataStructure;

namespace LeetCode
{
  public class Sqrt : BaseSolution
  {
    //二分查找
    public int Compute1(int input)
    {
      var start = 0;
      var mid = input / 2;
      var end = input;
      var pow = mid * mid;
      while (mid * mid != input)
      {
        if (pow < input)
        {
          start = mid;
          mid = (start + end) / 2;
          pow = mid * mid;
        }
        else if (pow > input)
        {
          end = mid;
          mid = (start + end) / 2;
          pow = mid * mid;
        }
      }
      return mid;
    }
    //牛顿迭代
  }
}
