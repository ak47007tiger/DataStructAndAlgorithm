using System;
using LeetCode.Main.Easy;
using LeetCode.Main.Toolkit;

namespace LeetCode.Main {
  public class Client : LeetCodeSolution{
    public static void Work(string[] args) {
      // var nums1 = new int[]{1,2,3,0,0,0};
      // var nums2 = new int[]{2,5,6};
      // new MergeSortedArray().Merge(nums1, 3, nums2,3);
      var nums1 = new int[]{1,0};
      var nums2 = new int[]{2};
      new MergeSortedArray().Merge(nums1, 1, nums2, 1);
      // var nums1 = new int[]{4,5,6,0,0,0};
      // var nums2 = new int[]{1,2,3};
      // new MergeSortedArray().Merge(nums1, 3, nums2, 3);
      printArray(nums1);
      Console.ReadKey();
    }
  }
}