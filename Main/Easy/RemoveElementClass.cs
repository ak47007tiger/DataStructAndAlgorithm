using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class RemoveElementClass {
    public int RemoveElement(int[] nums, int val) {
      if (nums == null || nums.Length == 0)return 0;

      int l = 0;
      for (int i = 0; i < nums.Length; i++)
        if (nums[i] != val)
          nums[l++] = nums[i];
      return l;
    }
  }
}