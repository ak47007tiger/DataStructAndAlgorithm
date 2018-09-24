using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy {
  /*
Given a binary tree, find its maximum depth.

The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Note: A leaf is a node with no children.

Example:

Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its depth = 3.
   */
  public class MaximumDepthOfBinaryTree {
    /*
    递归
    分别求左右子树的高，选大的
     */
    /*
    使用递归的条件，子问题同，只是输入不同
     */
    public int MaxDepth(TreeNode root) {
      if(root == null) return 0;
      return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
  }
}