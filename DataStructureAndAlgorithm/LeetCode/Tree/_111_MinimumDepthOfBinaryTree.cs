using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

Note: A leaf is a node with no children.

Example:

Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its minimum depth = 2.
 */

/*
反思
没有确认题意就开始做了
题目明确说明是叶子节点，即没有左右子节点的节点到跟节点的层数才是深度
第一次理解为只要出现没有左或者没有右节点就可以计算深度了
 */
namespace LeetCode.Easy {
  public class MinimumDepthOfBinaryTree {
    public int MinDepth(TreeNode root) {
      if(root == null) return 0;
      if(root.left == null && root.right == null){
        return 1;
      }
      if(root.left == null){
        return MinDepth(root.right) + 1;
      }
      if(root.right == null){
        return MinDepth(root.left) + 1;
      }
      return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
  }
}