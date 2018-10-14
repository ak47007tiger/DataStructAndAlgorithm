using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

Note:

Your returned answers (both index1 and index2) are not zero-based.
You may assume that each input would have exactly one solution and you may not use the same element twice.
Example:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
 */

/*
暴力解法
遍历方式

优化
减除不可能的范围

hash表解法
value,index(all value < target)
if(contains target - value) then get index
 */
namespace LeetCode.Easy {

  public class TwoSumII_InputArrayIsSorted : BaseSolution{
    public int[] TwoSum(int[] numbers, int target) {
      //怎么处理相同的值，如果出现相同的值了，表明是连续的，直接用最新的
      //如果target == 8， [2,0,4,4,9,15]
      Dictionary<int, int> dic = new Dictionary<int, int>();
      for (var i = numbers.Length - 1; i >= 0; i--) {
        var value = numbers[i];
        var searchValue = target - value;
        if (dic.ContainsKey(searchValue)) {
          return new int[] { i + 1, dic[searchValue] + 1 };
        }
        if(dic.ContainsKey(value)){
          dic[value] = i;
        }else{
          dic.Add(value, i);
        }
      }
      return null;
    }

    public int[] TwoSum1(int[] numbers, int target) {
      for (var i = numbers.Length - 1; i > 0; i--) {
        if (numbers[i] < target) {
          for (var j = 0; j < i; j++) {
            if (numbers[i] + numbers[j] == target) {
              return new int[] { i, j };
            }
          }
        }
      }
      return null;
    }
  }

}