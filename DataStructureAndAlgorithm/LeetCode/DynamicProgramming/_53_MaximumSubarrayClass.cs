using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Example:

Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
Follow up:

If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
 */
/*
暴力解法
对所有可能的i,j段求和

求最大最小或者，策略不同结果不同的问题，尝试动态规划
递推公式
dp是什么
先确定dp[i]代表什么
这样有2个输入确定一个范围，dp是范围做差
sum[i],sum[i+k]
dp(i,i+k) = sum[i+k] - sum[i]
dp(i,j), dp(i-1,j)
用最大的sum - 最小的sum
 */
namespace LeetCode {

  public class MaximumSubarrayClass : BaseSolution{
    public int MaxSubArray(int[] nums) {
      if (nums == null || nums.Length == 0)return 0;

      if (nums.Length == 1)return nums[0];
      var sums = new int[nums.Length];
      sums[0] = nums[0];

      var sumMaxIndex = 0;
      var sumMax = sums[0];

      var sumMinIndex = -1;
      var sumMin = 0;
      if(sums[0] < sumMin){
        sumMinIndex = 0;
        sumMin = sums[0];
      }
      var sumMin2 = sumMin;

      for (var i = 1; i < sums.Length; i++) {
        sums[i] = sums[i - 1] + nums[i];
        if (sums[i] >= sumMax) {
          sumMax = sums[i];
          sumMaxIndex = i;
        }
        if (sums[i] < sumMin) {
          sumMin2 = sumMin;
          sumMin = sums[i];
          sumMinIndex = i;
        }
      }
      printArray(sums);
      print(sumMinIndex, sumMaxIndex);
      if (sumMinIndex < sumMaxIndex) {
        return sumMax - sumMin;
      }
      if (sumMinIndex > sumMaxIndex) {
        var maxMin = 0;
        for (var i = 0; i < sumMaxIndex; i++) {
          maxMin = Math.Min(maxMin, sums[i]);
        }
        if (sumMinIndex == sums.Length - 1) {
          return Math.Max(sumMax - maxMin, sumMin - sumMin2);
        } else {
          var minMax = sums[sumMinIndex + 1];
          for (var i = sumMinIndex + 2; i < sumMaxIndex; i++) {
            minMax = Math.Max(minMax, sums[i]);
          }
          return Math.Max(sumMax - maxMin, minMax - sumMin);
        }
      }
      return 0;
    }

    int MaxSubArray(int[] nums, int start, int end) {

      if (start == end)return nums[start];

      var mid = (start + end) / 2;
      var left = MaxSubArray(nums, start, mid);
      var right = MaxSubArray(nums, mid + 1, end);
      return 0;
    }

    class Data {
      int l;
      int r;
      public Data(int l, int r) {
        this.l = l;
        this.r = r;
      }
      public override int GetHashCode() {
        return string.Format("{0}{1}", l, r).GetHashCode();
      }
      public override bool Equals(object obj) {
        if (obj == null)return false;
        if (obj == this)return true;
        if (obj is Data) {
          var d = (Data)obj;
          return d.l == l && d.r == r;
        }
        return false;
      }
    }

    public int MaxSubArray1(int[] nums) {
      if (nums.Length == 1)return nums[0];

      int max = int.MinValue;
      HashSet<Data> set = new HashSet<Data>();
      for (int i = 0; i < nums.Length; i++) {
        for (int lc = 0; lc <= i; lc++) {
          for (int rc = 0; rc <= nums.Length - i - 1; rc++) {
            var data = new Data(i - lc, i - rc);
            if (set.Contains(data))continue;

            if (i - lc == i + rc) {
              if (max < nums[i])
                max = nums[i];
              set.Add(data);
              continue;
            }

            int temp = 0;
            for (int p = i - lc; p <= i + rc; p++)
              temp += nums[p];
            if (max < temp)
              max = temp;
            set.Add(data);
          }
        }
      }
      return max;
    }

    public int MaxSubArray2(int[] nums) {
      int max = int.MinValue;
      for (int l = 0; l < nums.Length; l++) {
        for (int r = l; r < nums.Length; r++) {
          int temp = 0;
          for (int p = l; p <= r; p++)
            temp += nums[p];
          if (max < temp)
            max = temp;
        }
      }
      return max;
    }

    public int MaxSubArray3(int[] nums) {
      int max_ending_here = nums[0];
      int max_so_far = max_ending_here;
      for (int i = 1; i < nums.Length; i++) {
        var x = nums[i];
        max_ending_here = Math.Max(x, max_ending_here + x);
        max_so_far = Math.Max(max_so_far, max_ending_here);
      }
      return max_so_far;
    }
  }
}