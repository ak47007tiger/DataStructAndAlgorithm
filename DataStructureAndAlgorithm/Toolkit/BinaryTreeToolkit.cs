using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Toolkit
{

  public class BinaryTreeToolkit : BaseSolution
  {

    public static TreeNode BuildBinarySearchTree(int[] nums)
    {
      if (nums == null || nums.Length == 0)
      {
        return null;
      }
      var root = new TreeNode(nums[0]);
      for (var i = 1; i < nums.Length; i++)
      {
        InsertBinaryTreeNode(root, nums[i]);
      }
      return root;
    }

    public static TreeNode InsertBinaryTreeNode(TreeNode node, int value)
    {
      if (node == null) { return new TreeNode(value); }
      if (value < node.val)
      {
        node.left = InsertBinaryTreeNode(node.left, value);
      }
      else
      {
        node.right = InsertBinaryTreeNode(node.right, value);
      }
      return node;
    }

    public static TreeNode BuildBalencedBST(int[] nums)
    {
      return null;
    }

    public static TreeNode BuildBinaryTree(string[] inputs)
    {
      if (inputs == null || inputs.Length == 0 || string.IsNullOrEmpty(inputs[0]))
      {
        return null;
      }
      TreeNode[] nodes = ToArray(inputs);
      return ToTree(nodes);
    }

    public static TreeNode CreateTree(params object[] objs){
      return ToTree(ToArray(objs));
    }

    public static TreeNode ToTree(TreeNode[] nodes)
    {
      if (nodes == null || nodes.Length == 0)
      {
        return null;
      }
      var root = nodes[0];
      for (var i = 0; i < nodes.Length; i++)
      {
        var cur = nodes[i];
        if (cur == null)
        {
          continue;
        }
        var cLIndex = i * 2 + 1;
        if (cLIndex < nodes.Length)
        {
          cur.left = nodes[cLIndex];
        }
        var cRIndex = cLIndex + 1;
        if (cRIndex < nodes.Length)
        {
          cur.right = nodes[cRIndex];
        }
      }
      return root;
    }

    public static TreeNode[] ToArray(string[] inputs)
    {
      if (inputs == null || inputs.Length == 0 || string.IsNullOrEmpty(inputs[0]))
      {
        return null;
      }
      var array = new TreeNode[inputs.Length];
      for (var i = 0; i < inputs.Length; i++)
      {
        if (!string.IsNullOrEmpty(inputs[i]))
        {
          array[i] = new TreeNode(int.Parse(inputs[i]));
        }
      }
      return array;
    }

    public static TreeNode[] ToArray(object[] inputs)
    {
      if (inputs == null || inputs.Length == 0 || string.IsNullOrEmpty(inputs[0].ToString()))
      {
        return null;
      }
      var array = new TreeNode[inputs.Length];
      for (var i = 0; i < inputs.Length; i++)
      {
        object v = inputs[i];
        if (null == v)
        {
          continue;
        }
        array[i] = new TreeNode((int)v);
      }
      return array;
    }

  }

}