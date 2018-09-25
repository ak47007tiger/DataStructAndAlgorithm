using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStruct;

namespace NiuKeWang {
  public class BinaryTreeTheme : BaseSolution {

    public static void InOrderTravelRecursive(TreeNode node) {
      if (node == null) {
        return;
      }
      InOrderTravelRecursive(node.left);
      print(node.val);
      print(',');
      InOrderTravelRecursive(node.right);
    }

    public static void InOrderTravelNotRecursive(TreeNode node) {
      if (node == null) {
        return;
      }
      var stack = new Stack<TreeNode>();
      var cur = node;
      stack.Push(node);
      while (stack.Count > 0) {
        if (cur.left != null) {
          stack.Push(cur.left);
          cur = cur.left;
        } else {
          cur = stack.Pop();
          print(cur.val);
          print(',');
          if (cur.right != null) {
            stack.Push(cur.right);
            cur = cur.right;
          }
        }
      }
    }

  }
}
