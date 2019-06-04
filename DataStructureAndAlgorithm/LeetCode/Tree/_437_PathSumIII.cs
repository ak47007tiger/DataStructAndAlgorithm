using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

namespace LeetCode
{

  /*

root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

      10
     /  \
    5   -3
   / \    \
  3   2   11
 / \   \
3  -2   1

Return 3. The paths that sum to 8 are:

1.  5 -> 3
2.  5 -> 2 -> 1
3. -3 -> 11

  从父节点到子节点，不一定非要从root到leaf，路径和为给定值的所有路径

  对每一个节点用递归

  ！
  双重递归！！
  1 对每个节点递归求从这个节点出发可以有多少线满足条件
  2 从一个节点出发，看这个节点所有的线中有多少可以满足
   */
  public class PathSumIII : BaseSolution
  {
    public int PathSum(TreeNode root, int sum)
    {
      if (root == null)
      {
        return 0;
      }
      //下面这个写法错误的原因是，可能会导致包含重复结果
      // var cRoot = PathSum(root.left, sum - root.val) + PathSum(root.right, sum - root.val);
      var cLeft = PathSum(root.left, sum);
      var cRight = PathSum(root.right, sum);
      return Sum(root, sum) + cLeft + cRight;
    }

    public int Sum(TreeNode node, int sum)
    {
      if (node == null)
      {
        return 0;
      }
      var count = 0;
      if (node.val == sum)
      {
        count++;
      }
      return count + Sum(node.left, sum - node.val) + Sum(node.right, sum - node.val);
    }

    public static void Test()
    {
      /*
      [10,5,-3,3,2,null,11,3,-2,null,1]
      8 
      */
      print(new PathSumIII().PathSum(BinaryTreeToolkit.CreateTree(
        10, 5, -3, 3, 2, null, 11, 3, -2, null, 1), 8));
    }

  }

  /*
      int pathSum(TreeNode* root, int sum) {
          if (!root) return 0;
          return sumUp(root, 0, sum) + pathSum(root->left, sum) + pathSum(root->right, sum);
      }
      int sumUp(TreeNode* node, int pre, int& sum) {
          if (!node) return 0;
          int cur = pre + node->val;
          return (cur == sum) + sumUp(node->left, cur, sum) + sumUp(node->right, cur, sum);
      }
   */
}
