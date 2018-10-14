using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.


In Pascal's triangle, each number is the sum of the two numbers directly above it.

Example:

Input: 5
Output:
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
 */

/*
1 0
2 0
3 1 1
4 2 1,2
5 3 1,2,3

找到公式，找到和上一行索引的关系
 */

namespace LeetCode.Easy {

  public class Pascal_s_Triangle : BaseSolution{

    public IList<IList<int>> Generate(int numRows) {
      IList<IList<int>> lists = new List<IList<int>>();
      for(var i = 0; i < numRows; i++){
        var list = new List<int>();
        list.Add(1);
        if(i > 0){
          var previousList = lists[i - 1];
          for(var j = 1; j < i; j++){
            var value = previousList[j] + previousList[j - 1];
            list.Add(value);
          }
          list.Add(1);
        }
        lists.Add(list);
      }
      return lists;
    }

  }

}