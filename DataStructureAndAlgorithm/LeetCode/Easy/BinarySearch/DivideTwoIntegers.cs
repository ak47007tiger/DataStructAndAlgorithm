using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

/*
Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.

Return the quotient after dividing dividend by divisor.

The integer division should truncate toward zero.

Example 1:

Input: dividend = 10, divisor = 3
Output: 3
Example 2:

Input: dividend = 7, divisor = -3
Output: -2
Note:

Both dividend and divisor will be 32-bit signed integers.
The divisor will never be 0.
Assume we are dealing with an environment which could only store integers 
within the 32-bit signed integer range: [−231,  231 − 1]. 
For the purpose of this problem, assume that your function returns 231 − 1 when the division result overflows.
 */

/*
除法的又一层意思
被除数乘多少最接近并且小于除数
找到这样一个乘数，乘上之后比目标值小，乘上这个值+上除数>目标值
第一个能够比目标值大的乘数-1
 */

namespace LeetCode.Easy {
  public class DivideTwoIntegers : BaseSolution {
    public int Divide(int dividend, int divisor) {
      if(divisor == 1) return (int)dividend;
      if(divisor == -1) {
        if(dividend == int.MinValue) return int.MaxValue;
        return -dividend;
      }

      if (dividend > 0 && divisor > 0) {
        return DivideEx(dividend, divisor);
      }
      if (dividend < 0 && divisor < 0) {
        return DivideEx(-(long)dividend, -(long)divisor);
      }
      if (divisor < 0) {
        return -DivideEx(dividend, -(long)divisor);
      }
      return -DivideEx(-(long)dividend, divisor);
    }

    int DivideEx(long dividend, long divisor) {
      var previous = dividend;
      var start = dividend;
      // var limtCount = 40;
      while (true) {
        var compute = Mul(divisor, start);
        if (compute < dividend) {
          if (Mul(divisor, start + 1) > dividend) {
            return Wrap(start);
          }
          start = (start >> 1) + (previous >> 1);
        } else if (compute > dividend) {
          if (Mul(divisor, start - 1) < dividend) {
            return Wrap(start - 1);
          }
          previous = start;
          start = start >> 1;
        } else {
          return Wrap(start);
        }
        // print(start);
        // print(',');
        // print(limtCount);
        // print(',');
        // if(limtCount -- < 0) return 404;
      }
    }

    int Wrap(long v) {
      if (v > int.MaxValue) {
        return int.MaxValue;
      }
      return (int)v;
    }

    public long Mul(long v, long mulv) {
      var v2 = v;
      if (mulv == 0)return 0;
      while(2 <= mulv){
        mulv = mulv >> 1;
        v = v << 1;
      }

      println("+" + mulv);

      if(mulv > 0){
        return v + v2;
      }
      return v;
    }
  }
}