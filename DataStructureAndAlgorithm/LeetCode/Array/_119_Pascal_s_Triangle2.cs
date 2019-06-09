using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

Note that the row index starts from 0.


In Pascal's triangle, each number is the sum of the two numbers directly above it.

Example:

Input: 3
Output: [1,3,3,1]
Follow up:

Could you optimize your algorithm to use only O(k) extra space?
 */

/*
方法，循环利用
利用最后一个多出来的位置
从后往前计算，然后对称过去
n是整型，(n + 1) / 2 可以得到一个分界点，这个分界点使得 n / 2 == (n + 1) / 2
如果n是奇数，那么 n / 2 == (n - 1) / 2, n / 2 == (n + 1) / 2 - 1
如果n是偶数，那么 n / 2 == (n + 1) / 2
 */

/*
总结1
循环嵌套中，内循环依赖外循环的值，一般是范围和边界依赖外循环的循环控制变量
一般这个时候内循环的边界值和外循环的循环控制变量的意义上容易混淆
这个时候需要十分小心，最好使用一个单独的变量表达内循环边界

总结2
注意数组对称拷贝时的奇偶边界问题
 */

namespace LeetCode {

  public class Pascal_s_Triangle2 : BaseSolution {

    public IList<int> GetRow(int rowIndex) {
      if (rowIndex == 0) {
        return new int[] { 1 };
      }
      if (rowIndex == 1) {
        return new int[] { 1, 1 };
      }
      var buf = new int[rowIndex + 1];
      for (var i = 0; i < buf.Length; i++) {
        buf[i] = 1;
      }
      for (var i = 2; i <= rowIndex; i++) {
        var previousBuf = buf;
        var end = i / 2;
        for (var j = 1; j <= end; j++) {
          var value = previousBuf[j] + previousBuf[j - 1];
          var reverseIndex = i - j;
          buf[reverseIndex] = value;
        }
        //not copy last position value, so let j < rowIndex
        if ((i + 1) % 2 == 0) {
          for (var j = end + 1; j < i; j++) {
            var offset = j - end;
            var to = end + 1 - offset;
            buf[to] = buf[j];
          }
        } else {
          for (var j = end; j < i; j++) {
            var offset = j - end;
            var to = end - offset;
            buf[to] = buf[j];
          }
        }
      }
      return buf;
    }

  }

}