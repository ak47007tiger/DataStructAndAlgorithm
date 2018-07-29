using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class MaximumSubarrayClass {
    public int MaxSubArray(int[] nums) {
      if (nums == null || nums.Length == 0)return 0;

      if (nums.Length == 1)return nums[0];

      return MaxSubArray(nums, 0, nums.Length - 1);
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