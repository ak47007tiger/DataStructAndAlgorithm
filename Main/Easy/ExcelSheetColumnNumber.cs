using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given a column title as appear in an Excel sheet, return its corresponding column number.

For example:

    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 
    ...
Example 1:

Input: "A"
Output: 1
Example 2:

Input: "AB"
Output: 28
Example 3:

Input: "ZY"
Output: 701
 */
/*
进制转换
 */
namespace LeetCode.Main.Easy {
  public class ExcelSheetColumnNumber {
    public int TitleToNumber(string s) {
      var dic = new Dictionary<char, int>();
      var index = 1;
      for (var i = 'A'; i <= 'Z'; i++) {
        dic.Add((char)i, index);
        index++;
      }
      var sum = 0;
      var stack = new Stack<char>();
      var count = 0;
      for (var i = s.Length - 1; i >= 0; i--) {
        var ic = dic[s[i]];
        sum += (ic * (int)Math.Pow(26,count));
        stack.Push(s[i]);
        count++;
      }
      return sum;
    }
  }
}