using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace LeetCode {
  /*
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

Note:

The number of elements initialized in nums1 and nums2 are m and n respectively.
You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
Example:

Input:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

Output: [1,2,2,3,5,6]
   */

  /*
  概括：对数组1执行插入排序，删掉重复的

  基本
  1 从nums2里取一个数a
  2 跟nums1里的数比较
  3 如果nums1里面有了，取下一个直到最后一个
  4 重复2

  优化
  从nums2取的数比较到一个值之后，后面的值就都不需要跟前面的比较了，因为一定大于前面的
  从nums2取的下一个数跟
   */
  public class MergeSortedArray : BaseSolution{

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
      if(m == 0){
        for(var i = 0; i < n; i++){
          nums1[i] = nums2[i];
        }
        return;
      }
      var j = 0;
      var mex = m;
      for (var i = 0; i < n; i++) {
        var num2 = nums2[i];
        for (j = 0; j < mex; j++) {
          var num1 = nums1[j];
          if (num2 < num1) {
            //后移nums1
            for(var k = mex; k > j; k--){
              nums1[k] = nums1[k - 1];
            }
            nums1[j] = num2;
            mex++;
            break;
          } else if (num2 == num1) {
            j++;
            for(var k = mex; k > j; k--){
              nums1[k] = nums1[k - 1];
            }
            nums1[j] = num2;
            mex++;
            break;
          } else if (num2 > num1) {
            if(j == mex - 1){
              //追加到末尾
              nums1[mex] = num2;
              mex++;
              break;
            }
          }
        }
      }
    }

  }
}