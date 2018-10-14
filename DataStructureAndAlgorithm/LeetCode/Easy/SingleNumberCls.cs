using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:

Input: [2,2,1]
Output: 1
Example 2:

Input: [4,1,2,1,2]
Output: 4
 */

/*
排序和查找
1 排序，由小到大
2 从前往后找
如果找到一个数，比前面的大，并且比后面的小，返回它

hashtable
第一次循环放入
找到表里面count为1的
 */

namespace LeetCode.Easy {
  public class SingleNumberCls : BaseSolution {
    public int SingleNumber(int[] nums) {
      if (nums.Length == 1) {
        return nums[0];
      }

      var dic = new Dictionary<int, int>();
      for(var i = 0; i < nums.Length; i++){
        if(dic.ContainsKey(nums[i])){
          dic[nums[i]]++;
        }else{
          dic.Add(nums[i], 1);
        }
      }
      for(var i = 0; i < nums.Length; i++){
        if(dic[nums[i]] == 1) return nums[i];
      }
      return -1;
    }

    public int SingleNumber1(int[] nums) {
      if (nums.Length == 1) {
        return nums[0];
      }

      QuickSort(nums, 0, nums.Length - 1);

      if (nums[0] != nums[1]) {
        return nums[0];
      }

      if (nums[nums.Length - 1] != nums[nums.Length - 2]) {
        return nums[nums.Length - 1];
      }

      for (var i = 1; i < nums.Length - 1; i++) {
        if (nums[i - 1] != nums[i] && nums[i] != nums[i + 1]) {
          return nums[i];
        }
      }
      return -1;
    }

    /*
    快排的思想
    随机取一个数a, <a的放左边，其它放右边
    递归左右2边
     */
    public void QuickSort(int[] nums, int start, int end) {
      if (start >= end) return;

      var decideValue = nums[start];
      var i = start;
      var j = end;
      while (i < j) {
        while (i < j && nums[j] >= decideValue) {
          j--;
        }
        nums[i] = nums[j];
        while (i < j && nums[i] <= decideValue) {
          i++;
        }
        nums[j] = nums[i];
      }
      nums[i] = decideValue;
      QuickSort(nums, start, i - 1);
      QuickSort(nums, i + 1, end);
    }

  }

}