using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode {
  public class RemoveDuplicatesFromSortedArray {

    public int RemoveDuplicates(int[] nums) {
      if (nums == null || nums.Length == 0)
        return 0;
      var sortedEnd = 0;
      var unsorted = 1;
      while (unsorted < nums.Length) {
        if (nums[sortedEnd] != nums[unsorted]) {
          sortedEnd++;
          nums[sortedEnd] = nums[unsorted];
        }
        unsorted++;
      }
      return sortedEnd + 1;
    }

    public int _RemoveDulicates(int[] nums) {
      if (nums == null || nums.Length == 0)
        return 0;
      int m = 0;
      for (int i = 1; i < nums.Length; i++)
        if (nums[m] < nums[i]) {
          m++;
          nums[m] = nums[i];
        }
      return m + 1;
    }

    public int RemoveDuplicates0(int[] nums) {
      if (nums == null || nums.Length == 0)
        return 0;
      var newLength = nums.Length;
      var pickIndex = nums.Length - 1;
      while (pickIndex > 0) {
        if (nums[pickIndex - 1] == nums[pickIndex]) {
          var moveIndex = pickIndex;
          while (moveIndex < newLength) {
            nums[moveIndex - 1] = nums[moveIndex];
            moveIndex++;
          }
          newLength--;
        }
        pickIndex--;
      }
      return newLength;
    }

    public int RemoveDuplicates1(int[] nums) {
      if (nums == null || nums.Length == 0)
        return 0;
      var newLength = nums.Length;
      var pickIndex = 0;
      while (pickIndex < newLength - 1) {
        if (nums[pickIndex] == nums[pickIndex + 1]) {
          var moveIndex = pickIndex + 2;
          if (moveIndex < newLength) {
            while (moveIndex < newLength) {
              nums[moveIndex - 1] = nums[moveIndex];
              moveIndex++;
            }
            newLength--;
            continue;
          } else {
            return newLength - 1;
          }
        } else {
          pickIndex++;
        }
      }
      return newLength;
    }
  }
}