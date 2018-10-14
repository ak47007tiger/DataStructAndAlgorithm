using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

/*
Find the kth largest element in an unsorted array. 
Note that it is the kth largest element in the sorted order, not the kth distinct element.

Example 1:

Input: [3,2,1,5,6,4] and k = 2
Output: 5
Example 2:

Input: [3,2,3,1,2,4,5,5,6] and k = 4
Output: 4
Note: 
You may assume k is always valid, 1 ≤ k ≤ array's length.
 */

/*
1 先排序，然后找，排序的同时去掉重复元素
2 使用堆排序，构造大根堆
3 从最大的往小找，找K次，找到第K大的
 */
namespace LeetCode.Medium {
  public class KthLargestElementInAnArray :  BaseSolution{

  }
}