using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given a binary tree, determine if it is height-balanced.

For this problem, a height-balanced binary tree is defined as:

a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

Example 1:

Given the following tree [3,9,20,null,null,15,7]:

    3
   / \
  9  20
    /  \
   15   7
Return true.

Example 2:

Given the following tree [1,2,2,3,3,null,null,4,4]:

       1
      / \
     2   2
    / \
   3   3
  / \
 4   4
Return false.
 */

namespace LeetCode.Easy {
  public class BalancedBinaryTree {
    public bool IsBalanced(TreeNode root) {
      if(root == null) return true;
      if(Math.Abs(GetHeight(root.left) - GetHeight(root.right)) <= 1){
        return IsBalanced(root.left) && IsBalanced(root.right);
      }
      return false;
    }

    int GetHeight(TreeNode node){
      if(node == null) return 0;
      return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
    }

    /*
    非递归方式
     */
    int GetHeight1(TreeNode node){
      /*
      1 层序遍历，带着level信息
      2 关键点在于每次遍历下一层的时候记录下一层有多少个节点
       */
      return 0;
    }
  }
}