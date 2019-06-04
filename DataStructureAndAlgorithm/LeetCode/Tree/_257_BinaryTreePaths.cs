using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

namespace LeetCode
{
  /**
  输出所有从根节点到叶子节点的路径

  前序遍历，如果遇到叶子节点，输出路径信息
   */
  public class BinaryTreePathsCls : BaseSolution
  {
    public IList<string> BinaryTreePaths(TreeNode root)
    {
      var list = new List<string>();
      BinaryTreePaths(root, list, new List<TreeNode>());
      return list;
    }

    public void BinaryTreePaths(TreeNode root, IList<string> list, List<TreeNode> parents)
    {
      if (root == null)
      {
        return;
      }

      if (root.left == null && root.right == null)
      {
        var sbd = new StringBuilder();
        for (var i = 0; i < parents.Count; i++)
        {
          sbd.Append(parents[i].val).Append("->");
        }
        sbd.Append(root.val);
        list.Add(sbd.ToString());
      }
      else
      {
        parents.Add(root);
        BinaryTreePaths(root.left, list, parents);
        BinaryTreePaths(root.right, list, parents);
        // parents.Remove(root);
        parents.RemoveAt(parents.Count - 1);
      }
    }

    public static void Test()
    {
      printArray(new BinaryTreePathsCls().BinaryTreePaths(BinaryTreeToolkit.CreateTree(1,2,3,null,5)).ToArray());
      println();
    }

  }

}
