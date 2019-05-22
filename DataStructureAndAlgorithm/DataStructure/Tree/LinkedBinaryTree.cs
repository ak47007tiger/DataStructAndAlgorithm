namespace DataStructure
{
  using System.Collections.Generic;
  using System;

  public class LinkedBinaryTree : BaseSolution
  {
    TreeNode root;
    public TreeNode Create(Queue<int> queue)
    {
      if (queue.Count == 0)
      {
        return null;
      }

      root = new TreeNode(queue.Dequeue());
      root.left = Create(queue);
      root.right = Create(queue);

      return root;
    }

    //mid,left,right
    public void PreOrder(TreeNode node)
    {
      if (node == null)
      {
        return;
      }

      var stack = new Stack<TreeNode>();
      stack.Push(node);

      while (stack.Count > 0)
      {
        var top = stack.Pop();
        print(top.val);
        print(',');
        if (top.right != null)
        {
          stack.Push(top.right);
        }
        if (top.left != null)
        {
          stack.Push(top.left);
        }
      }
    }

    public void PreOrder_Recursively(TreeNode node)
    {
      if (null == node)
      {
        return;
      }

      print(node.val);
      print(',');

      InOrder_Recursively(node.left);

      InOrder_Recursively(node.right);
    }
    //,left mid,right
    public void InOrder(TreeNode node)
    {
      if (node == null)
      {
        return;
      }
      var stack = new Stack<TreeNode>();
      var cur = node;
      /*
      1 不断的把有左孩子的节点入栈，当没有左孩子的时候，处理结束，弹出栈顶，访问栈顶
      2 对栈顶的右孩子重复1
       */
      //
      //
      while (stack.Count > 0 || cur != null)
      {
        while(cur != null){
          stack.Push(cur);
          cur = cur.left;
        }
        cur = stack.Pop();
        //visit cur
        cur = cur.right;
      }
    }

    public void InOrder_Recursively(TreeNode node)
    {
      if (null == node)
      {
        return;
      }

      InOrder_Recursively(node.left);

      print(node.val);
      print(',');

      InOrder_Recursively(node.right);
    }

    //,left,right mid
    //用一个栈记录先序遍历的逆序
    public void PostOrder(TreeNode node)
    {
      if (null == node)
      {
        return;
      }

      var stack1 = new Stack<TreeNode>();
      var stack2 = new Stack<TreeNode>();
      stack1.Push(node);
      while (stack1.Count > 0)
      {
        var top = stack1.Pop();
        stack2.Push(top);

        if (top.left != null)
        {
          stack1.Push(top.left);
        }
        if (top.right != null)
        {
          stack1.Push(top.right);
        }
      }
    }

    public void PostOrder_Recursively(TreeNode node)
    {
      if (null == node)
      {
        return;
      }

      InOrder_Recursively(node.left);

      InOrder_Recursively(node.right);

      print(node.val);
      print(',');

    }

  }

}
