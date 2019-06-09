using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode {
  public class SearchInsertPosition {
    public int SearchInsert(int[] nums, int target) {
      if (target < nums[0])
        return 0;
      int i = 0;
      while (i < nums.Length) {
        if (nums[i] >= target)
          return i;
        i++;
      }
      return i;
    }
  }
}