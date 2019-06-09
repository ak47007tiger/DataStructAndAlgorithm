using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

Example:
Given nums = [-2, 0, 3, -5, 2, -1]

sumRange(0, 2) -> 1
sumRange(2, 5) -> -1
sumRange(0, 5) -> -3
Note:
You may assume that the array does not change.
There are many calls to sumRange function.
 */

/*
对数组的从i到j个元素求和
如何让速度最快
通过演算的方式，我找到了一个规律
例如
1,2,3,4

1,3,6,10
-,2,5,9
-,-,3,7
-,-,-,4

得到递推公式，f(i,j) = f(j,j) + f(i,j - 1)

暴力解法和cache我都做了
递推公式我也写对了
怎么就没AC呢...
原来我递推公式写错了...
傻到极点了，哎呦，挺傻哦

 */

namespace LeetCode {

  public class NumArray {

    int[] nums;

    Dictionary<string,int> dic = new Dictionary<string, int>();

    public NumArray(int[] nums) {
      this.nums = nums;
    }

    public int SumRange(int i, int j) {
      if(i < 0) return 0;

      if(i == j){
        return nums[i];
      }
      var key = i.ToString() + j.ToString();
      if(dic.ContainsKey(key)){
        return dic[key];
      }

      var sum = nums[j] + SumRange(i, j - 1);
      dic.Add(key, sum);
      return sum;
    }
  }
  public class NumArray1 {

    int[] nums;

    int[, ] dps;

    public NumArray1(int[] nums) {
      this.nums = nums;
      dps = new int[nums.Length, nums.Length];
      // for (var i = 0; i < nums.Length; i++) {
      //   Set(i, i, nums[i]);
      // }

      for (var i = 0; i < nums.Length; i++) {
        for (var j = i + 1; j < nums.Length; j++) {
          Set(i, j, nums[j] + Get(i,j-1));
        }
      }
    }

    int Get(int i, int j) {
      if (i < 0)return 0;
      if (i == j) {
        return nums[i];
      }
      return dps[i, j];
    }

    void Set(int i, int j, int v) {
      dps[i, j] = v;
    }

    public int SumRange(int i, int j) {
      var sum = 0;
      var stop = Math.Min(j, nums.Length - 1);
      for(var index = i; index <= stop; index++){
        sum+=nums[index];
      }
      return sum;
    }
  }

  /**
   * Your NumArray object will be instantiated and called as such:
   * NumArray obj = new NumArray(nums);
   * int param_1 = obj.SumRange(i,j);
   */

}