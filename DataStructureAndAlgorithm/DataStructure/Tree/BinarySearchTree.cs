using System;
namespace DataStructure
{
  /*
  二叉查找树 排序 前序遍历 O(n)
  重复元素处理
  1 链式结构
  2 放到右孩子
   */
  public class BinarySearchTree
  {
    TreeNode root;
    public TreeNode Find(int data)
    {
      return Find(data, root);
    }

    //递归查左右
    public static TreeNode Find(int data, TreeNode root)
    {
      if (root == null)
      {
        return null;
      }
      var head = root;
      if (head.val == data)
      {
        return head;
      }
      if (data < root.val)
      {
        Find(data, head.left);
      }
      return Find(data, head.right);
    }

    //
    public TreeNode Delete(int data)
    {
      if (root == null)
      {
        return null;
      }

      if (data < root.val)
      {
        return Delete(root, root.left, data);
      }
      else
      {
        return Delete(root, root.right, data);
      }
    }

    public static TreeNode Delete(TreeNode parent, TreeNode node, int data)
    {
      if (node.val == data)
      {
        if (node.left == null && node.right == null)
        {
          if (parent.left.val == data)
          {
            parent.left = null;
          }
          else
          {
            parent.right = null;
          }
          return node;
        }
        else if (node.left == null && node.right != null)
        {
          parent.right = node.right;
          return node;
        }
        else if (node.left != null && node.right == null)
        {
          parent.left = node.left;
          return node;
        }
        else
        {
          var min = FindMin(node);
          var minP = GetParent(node, min);
          minP.left = null;
          var temp = node.val;
          node.val = min.val;
          min.val = temp;
          return min;
        }
      }
      else if (data < node.val)
      {
        return Delete(node, node.left, data);
      }
      else
      {
        return Delete(node, node.right, data);
      }
    }

    private TreeNode GetParent(TreeNode node)
    {
      return GetParent(root, node);
    }

    private static TreeNode GetParent(TreeNode root, TreeNode node)
    {
      if (root == null)
      {
        return null;
      }
      if (node.val < root.val)
      {
        return GetParent(root.left, node);
      }
      return GetParent(root.right, node);
    }

    public TreeNode Insert(int data)
    {
      if (root == null)
      {
        root = new TreeNode(data);
        return root;
      }
      return Insert(data, root);
    }

    public static TreeNode Insert(int data, TreeNode node)
    {
      if (data < node.val)
      {
        if (node.left == null)
        {
          node.left = new TreeNode(data);
          return node.left;
        }
        return Insert(data, node.left);
      }
      if (node.right == null)
      {
        node.right = new TreeNode(data);
        return node.right;
      }
      return Insert(data, node.right);
    }

    public TreeNode FindMax()
    {
      return FindMax(root);
    }

    public static TreeNode FindMax(TreeNode root)
    {
      if (root == null)
      {
        return null;
      }
      if (root.right == null)
      {
        return root;
      }
      return FindMin(root.right);
    }

    public TreeNode FindMin()
    {
      return FindMin(root);
    }

    public static TreeNode FindMin(TreeNode root)
    {
      if (null == root)
      {
        return null;
      }
      if (root.left == null)
      {
        return root;
      }
      return FindMin(root.left);
    }

    //前驱结点：节点val值小于该节点val值并且值最大的节点 
    /*
    找的方法
    1 有左子树 找data节点左子树最大值节点
    2 没左孩子，是右孩子，返回parent
    3 没左孩子，是左孩子，往上追溯到一个是右节点的节点，返回它的父节点
    4 返回null
    
     */
    public TreeNode FindPre(int data)
    {
      if (root == null)
      {
        return null;
      }
      var node = Find(data);
      if (node.left != null)
      {
        return node.left;
      }
      var parent = GetParent(node);
      if (parent.right == node)
      {
        return parent;
      }
      var pp = GetParent(parent);
      while (pp != null && parent != null && pp.right != parent)
      {
        parent = pp;
        pp = GetParent(pp);
      }
      if (pp != null)
      {
        return pp;
      }
      return null;
    }

    //后继节点：节点val值大于该节点val值并且值最小的节点
    /*
    1 有右孩子，找右子树中最小的
    2 没右孩子，是左孩子，返回parent
    3 没右孩子，是右孩子，往上找第一个是左节点的节点，返回它的父节点
    4 return null
     */
    public TreeNode FindSuc(int data)
    {
      if (root == null)
      {
        return null;
      }
      var node = Find(data);
      if (node.right != null)
      {
        return FindMin(node.right);
      }

      var parent = GetParent(node);
      if (parent.left == node)
      {
        return parent;
      }

      var pp = GetParent(parent);
      while (pp != null && parent != null && parent == pp.left)
      {
        parent = pp;
        pp = GetParent(pp);
      }
      if (pp != null)
      {
        return pp;
      }
      return null;
    }

    public int GetHeight(TreeNode node)
    {
      if (null == node)
      {
        return 0;
      }
      return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
    }

  }

}
