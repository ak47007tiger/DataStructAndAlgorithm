using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStruct;

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
第一次思考
最小的作为root
逐个插入数组中其它的值
找到比插入的值大的最小节点a，如果找到了，新节点作为a.left，如果没有找到，新节点作为新的根
找到比插入的值小的最大节点b
  如果找到了，新节点作为b.right
  否则
    如果数为空，新节点作为新的根
    如果树不为空，新节点作为最大节点的右节点
 */
/*
开始写代码后的思考
自然的就想到了递归，我需要弄清楚递归和非递归转换的方法
 */
/*
第三次思考，因为没有搞对题目意思，所以没有通过，查阅网上资料找到了正确的理解，再战
 */
/*
第四次思考，递归要划分子问题，明确子问题要解决什么，比如这一题，是由数组生成bst，那么子问题也是要生成bst
 */
namespace LeetCode.Easy {
  public class ConvertSortedArrayToBinarySearchTree {

    public TreeNode SortedArrayToBST(int[] nums) {
      if(nums == null || nums.Length == 0) return null;
      
      return Build(nums, 0, nums.Length - 1);
    }
    
    TreeNode Build(int[] nums, int startIndex, int endIndex){
      if(startIndex == endIndex) return new TreeNode(nums[startIndex]);
      if(startIndex > endIndex) return null;
      
      var mid = (startIndex + endIndex) / 2;
      var root = new TreeNode(nums[mid]);
      root.left = Build(nums, startIndex, mid - 1);
      root.right = Build(nums, mid + 1, endIndex);
      return root;
    }
    
    public TreeNode SortedArrayToBST1(int[] nums) {
      if(nums == null || nums.Length == 0) return null;

      TreeNode root = new TreeNode(nums[0]);
      for(var i = 1; i < nums.Length; i++){
        var value = nums[i];
        Insert1(value, root);
      }
      return root;
    }

    void Insert1(int value, TreeNode node){
      if(value < node.val){
        if(node.left == null){
          node.left = new TreeNode(value);
        }else{
          Insert1(value, node.left);
        }
      }else{
        if(node.right == null){
          node.right = new TreeNode(value);
        }else{
          Insert1(value, node.right);
        }
      }
    }

  }

}