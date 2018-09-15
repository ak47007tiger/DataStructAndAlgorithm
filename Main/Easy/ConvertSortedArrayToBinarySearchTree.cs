using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

Example:

Given the sorted array: [-10,-3,0,5,9],

One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

      0
     / \
   -3   9
   /   /
 -10  5
 */

/*
最小的作为root
逐个插入数组中其它的值
如果破坏了搜索二叉树就进行调整
 */

namespace LeetCode.Main.Easy {
  public class ConvertSortedArrayToBinarySearchTree {
    
    public TreeNode SortedArrayToBST(int[] nums) {
      TreeNode root = new TreeNode(nums[0]);
      for(var i = 1; i < nums.Length; i++){
        var value = nums[i];
        var node = root;
        
      }
      return root;
    }

  }

}