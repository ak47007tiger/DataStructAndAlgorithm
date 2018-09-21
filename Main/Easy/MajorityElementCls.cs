using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the majority element always exist in the array.

Example 1:

Input: [3,2,3]
Output: 3
Example 2:

Input: [2,2,1,1,1,2,2]
Output: 2
 */
/*
思路
计算每个数出现的次数，选最大的
 */
namespace LeetCode.Main.Easy {

  public class MajorityElementCls {

    public int MajorityElement(int[] nums) {
      var dic = new Dictionary<int, int>();
      for (var i = 0; i < nums.Length; i++) {
        var value = nums[i];
        if (dic.ContainsKey(value)) {
          dic[value]++;
        } else {
          dic.Add(value, 1);
        }
      }

      var count = 0;
      var e = 0;
      foreach (var item in dic) {
        if (item.Value > count) {
          count = item.Value;
          e = item.Key;
        }
      }
      return e;
    }

  }

}
