using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given two binary trees, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

Example 1:

Input:     1         1
          / \       / \
         2   3     2   3

        [1,2,3],   [1,2,3]

Output: true
Example 2:

Input:     1         1
          /           \
         2             2

        [1,2],     [1,null,2]

Output: false
Example 3:

Input:     1         1
          / \       / \
         2   1     1   2

        [1,2,1],   [1,1,2]

Output: false
 */
namespace LeetCode {
  
  public class SameTree {
    //
    /*
    1 遍历一颗树，同步操作另一颗树，如果能在相同的位置找到相同的值，则2棵树相同
    2 用递归
     */
    public bool IsSameTree(TreeNode p, TreeNode q) {
      if(p == null && q == null){
        return true;
      }
      if((p == null && q != null) || (p != null && q == null)){
        return false;
      }
      if(p.val != q.val){
        return false;
      }
      return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
  }
}