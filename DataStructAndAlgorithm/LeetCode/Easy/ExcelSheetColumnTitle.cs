using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStruct;

/*
Given a positive integer, return its corresponding column title as appear in an Excel sheet.

For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 
    ...
Example 1:

Input: 1
Output: "A"
Example 2:

Input: 28
Output: "AB"
Example 3:

Input: 701
Output: "ZY"
 */

/*
A~ZA~ZA~Z...A~Z
任意一个i都能在上面找到
26 Z
26+1 AA
26 * 26 + 26 ZZ
ZAAA
26 * 26 * 26 + 26 + 1 AAA
 */

/*
思路
寻找数据关系，然后转换
规律：1-26跟字母的映射，超过一个26则开始循环
var left = dic[value / 26]
var right = dic[value % 26]

提交报错后的思考
发现这题利用的是进制转换的知识
从10进制转换为26进制
 */

namespace LeetCode.Easy {

  public class ExcelSheetColumnTitle : BaseSolution {
    public string ConvertToTitle(int n) {
      var dic = new char['Z' - 'A' + 1];
      //0,'A'
      //25,'Z'
      for (var i = 0; i < 'Z' - 'A' + 1; i++) {
        dic[i] = (char) ('A' + i);
      }

      var list = new List<int>();
      var value = n - 1;
      while (value >= 0) {
        list.Add(value % 26);
        value = (value / 26) - 1;
      }
      if (list.Count == 1) {
        return dic[list[0]].ToString();
      }
      var sbd = new StringBuilder();
      for(var i = list.Count - 1; i >= 0; i--){
        sbd.Append(dic[list[i]]);
      }
      return sbd.ToString();
    }
  }

}