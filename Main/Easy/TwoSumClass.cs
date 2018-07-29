using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class TwoSumClass {
    int sortUnit(int[] array, int low, int high) {
      int key = array[low];
      while (low < high) {
        while (low < high && array[high] >= key)
          high--;
        array[low] = array[high];
        while (low < high && array[low] <= key)
          low++;
        array[high] = array[low];
      }
      array[low] = key;
      return high;
    }

    public void quickSort(int[] array, int low, int high) {
      if (low >= high)
        return;
      int index = sortUnit(array, low, high);
      quickSort(array, low, index - 1);
      quickSort(array, index + 1, high);
    }

    public int binary(int[] array, int value, int low, int high) {
      int middle;
      while (low <= high) {
        middle = (high + low) / 2;
        if (array[middle] == value)
          return middle;
        else if (array[middle] > value)
          high = middle - 1;
        else
          low = middle + 1;
      }
      return -1;
    }

    public int violenceSearch(int[] array, int target, int low, int high) {
      if (low > high)
        return -1;
      for (int i = low; i <= high; i++) {
        if (array[i] == target)
          return i;
      }
      return -1;
    }

    public int[] TwoSum(int[] nums, int target) {
      int[] array = (int[])nums.Clone();
      quickSort(nums, 0, nums.Length - 1);

      int[] indexes = null;
      for (int i = 0; i < nums.Length; i++) {
        int i1 = binary(nums, target - nums[i], 0, i - 1);
        if (i1 >= 0)
          indexes = new int[] { i1, i };
        i1 = binary(nums, target - nums[i], i + 1, nums.Length - 1);
        if (i1 > 0)
          indexes = new int[] { i, i1 };
      }

      if (indexes == null)
        return new int[] {-1, -1 };
      else {
        int i1 = violenceSearch(array, nums[indexes[0]], 0, array.Length - 1);
        int i2 = violenceSearch(array, nums[indexes[1]], 0, array.Length - 1);
        if (i1 == i2) {
          i2 = violenceSearch(array, nums[indexes[1]], i1 + 1, array.Length - 1);
        }
        return new int[] { i1, i2 };
      }
    }
  }
}