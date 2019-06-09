/*
Given an array, rotate the array to the right by k steps, where k is non-negative.

Example 1:

Input: [1,2,3,4,5,6,7] and k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: [-1,-100,3,99] and k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
Note:

Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
Could you do it in-place with O(1) extra space?
 */

namespace LeetCode {
  public class RotateArray {
    /*
    需要一个下标变换
    k < length
      把后面k个数移动到前面
    k == length
      什么也不做
    k > length
      把k % length移动到前面
     */
    public void Solution3(int[] nums, int k) {
      if (k == nums.Length || k % nums.Length == 0) return;
      var fk = k;
      if (k > nums.Length) {
        fk = k % nums.Length;
      }
      var space = new int[fk];
      //copy
      for (var i = nums.Length - fk; i < nums.Length; i++) {
        space[i + fk - nums.Length] = nums[i];
      }
      //move
      for (var i = nums.Length - fk - 1; i >= 0; i--) {
        nums[i + fk] = nums[i];
      }
      //copy
      for (var i = 0; i < fk; i++) {
        nums[i] = space[i];
      }
    }

    public void Solution2(int[] nums, int k) {
      if (k == nums.Length || k % nums.Length == 0) return;
      var fk = k;
      if (k > nums.Length) {
        fk = k % nums.Length;
      }
      var i = 0;
      while (i < fk) {
        var temp = nums[nums.Length - 1];
        for (var j = nums.Length - 1; j > 0; j--) {
          nums[j] = nums[j - 1];
        }
        nums[0] = temp;
        i++;
      }
    }

    public void Solution1(int[] nums, int k) {
      var i = 0;
      while (i < k) {
        var temp = nums[nums.Length - 1];
        for (var j = nums.Length - 1; j > 0; j--) {
          nums[j] = nums[j - 1];
        }
        nums[0] = temp;
        i++;
      }
    }
  }

}