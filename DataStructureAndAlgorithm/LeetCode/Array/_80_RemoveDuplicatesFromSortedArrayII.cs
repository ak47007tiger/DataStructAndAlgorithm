using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

namespace LeetCode.Medium
{
    /*
    Given a sorted array nums, remove the duplicates in-place such that duplicates appeared at most twice and return the new length.

  Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

  Example 1:

  Given nums = [1,1,1,2,2,3],

  Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.

  It doesn't matter what you leave beyond the returned length.
  Example 2:

  Given nums = [0,0,1,1,1,1,2,3,3],

  Your function should return length = 7, with the first seven elements of nums being modified to 0, 0, 1, 1, 2, 3 and 3 respectively.

  It doesn't matter what values are set beyond the returned length.
  Clarification:

  Confused why the returned value is an integer but your answer is an array?

  Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.

  Internally you can think of this:

  // nums is passed in by reference. (i.e., without making a copy)
  int len = removeDuplicates(nums);

  // any modification to nums in your function would be known by the caller.
  // using the length returned by your function, it prints the first len elements.
  for (int i = 0; i < len; i++) {
      print(nums[i]);
  }
     */

     /*
     my solution
     1
     已经排序的数组，删除里面的重复元素，最多运行重复2个，返回新数组长度
     计数、移动数组
     new length = origion length - 移动次数
     从前往后计数，超过2个之后把后面的往前复制，覆盖掉，再次从上一个位置计数

    2 插入排序
    插入的位置，插入的数值，当前数据位置，最多插入2个一样的，超了就跳过
      */

    /*
    other solution
    这里允许最多重复的次数是两次，那么我们就需要用一个变量count来记录还允许有几次重复，count初始化为1，
    如果出现过一次重复，则count递减1，那么下次再出现重复，快指针直接前进一步，如果这时候不是重复的，则count恢复1，
    由于整个数组是有序的，所以一旦出现不重复的数，则一定比这个数大，此数之后不会再有重复项
    int removeDuplicates(int A[], int n) {
      if (n <= 2) return n;
      int pre = 0, cur = 1, count = 1;
      while (cur < n) {
          if (A[pre] == A[cur] && count == 0) ++cur;
          else {
              if (A[pre] == A[cur]) --count;
              else count = 1;
              A[++pre] = A[cur++];
          }
      }
      return pre + 1;
    }
     */
    public class RemoveDuplicatesFromSortedArrayII : BaseSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
          
          return 0;
        }

        public int RemoveDuplicates_1(int[] nums)
        {
          int curVal = nums[0];
          int counter = 0;
          int moveCount = 0;
          for(var i = 0; i < nums.Length; i++){
            if(nums[i] == curVal){
              if(counter == 2){
                //从后往前覆盖复制            
                for(var j = i; j < nums.Length - moveCount - 1; j++){
                  nums[j] = nums[j + 1];
                }
                moveCount++;
              }else{
                counter++;
              }
            }
          }
          return nums.Length - moveCount;
        }
    }
}