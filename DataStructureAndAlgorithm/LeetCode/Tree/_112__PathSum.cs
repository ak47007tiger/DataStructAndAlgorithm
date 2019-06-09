using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

Note: A leaf is a node with no children.

Example:

Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \      \
7    2      1
return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
 */

/*
第一次思考
审题
存在一个叶子节点到跟节点的数加起来的值和sum相等，返回true，否则，返回false
深度优先遍历，并且每次回退的时候当前值减去丢掉的值
可以用递归
1 递归的子问题相同结构
2 相同结构的子问题加上一个已知的问题
3 相同结构的多个子问题+多个已知问题
 */
/*
总结，一般算法题流程
审题，确定做什么
解法，确定用什么思想和方式，用什么数据结构，动态规划，递归，排序，查找，根据要什么数据，这些数据如果满足什么特征就可以来选择解法
套路，找解法对应的套路
实现，确定边界条件，完成数据处理的流程
检测，确认结果是否正确

总结，开放式算法题流程
需要进行建模，转换为一般算法题

需要研究的算法题
说到底还是处理数据
构造需要的数据结构
尝试一般解法
如果一般解法无法奏效，研究特殊解法
解题就是寻找这个题对应的问题的规律和特征并且利用

在已有的知识里寻找解法，如果解不出来，根据题目增加知识，直到知识中包含了解法
 */
namespace LeetCode {

  public class PathSum {
    
    public bool HasPathSum(TreeNode root, int sum) {
      if(root == null) return false;
      if(root.left == null && root.right == null){
        return root.val == sum;
      }
      if(root.left == null){
        return HasPathSum(root.right, sum - root.val);
      }
      if(root.right == null){
        return HasPathSum(root.left, sum - root.val);
      }
      return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }

  }

}
