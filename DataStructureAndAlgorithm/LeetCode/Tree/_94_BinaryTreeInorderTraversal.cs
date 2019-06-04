using System.Linq;
namespace LeetCode
{
  using System.Collections.Generic;
  using DataStructure;
  using DataStructure.Toolkit;

  /*
  中序遍历二叉树，左中右的顺序
  非递归实现
   */

  public class BinaryTreeInorderTraversal : BaseSolution
  {

    public IList<int> InorderTraversal(TreeNode root)
    {
      if (root == null)
      {
        return new List<int>();
      }

      var stack = new Stack<TreeNode>();

      var list = new List<int>();
      var cur = root;
      
      while (stack.Count > 0 || cur != null)
      {
        if(cur != null){
          stack.Push(cur);
          cur = cur.left;
        }else{
          cur = stack.Pop();
          list.Add(cur.val);
          cur = cur.right;
        }
      }

      return list;
    }

    public static void Test()
    {
      var tree = BinaryTreeToolkit.CreateTree(2, 3, null, 1);
      printArray(new BinaryTreeInorderTraversal().InorderTraversal(tree).ToArray());
    }

    public IList<int> InorderTraversal2(TreeNode root)
    {
      List<int> list = new List<int>();
      SubInorderTraversal2(list, root);
      return list;
    }

    public void SubInorderTraversal2(IList<int> list, TreeNode root)
    {
      if (null == root)
      {
        return;
      }

      SubInorderTraversal2(list, root.left);

      list.Add(root.val);

      SubInorderTraversal2(list, root.right);
    }

  }

}