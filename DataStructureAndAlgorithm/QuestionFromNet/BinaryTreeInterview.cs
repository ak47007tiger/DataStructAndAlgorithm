using System.Collections.Generic;
namespace DataStructure.Interview
{
  public class BinaryTreeInterview : BaseSolution
  {

    //judge the serial is post-order traversal of binary search tree
    /**
    找到左子树序列，找到右子树序列
    递归地判断序列是否是后续遍历序列
     */

    public bool IsPostOrder(int[] array, int start, int end)
    {
      var rootVal = array[end];
      var leftEnd = start;
      while (array[leftEnd] < rootVal)
      {
        leftEnd++;
      }
      //没有右子树
      if (leftEnd == end)
      {
        return IsPostOrder(array, start, leftEnd - 1);
      }

      leftEnd--;

      if (!IsPostOrder(array, start, leftEnd))
      {
        return false;
      }

      var rightStart = leftEnd + 1;
      var rightEnd = end - 1;
      return IsPostOrder(array, rightStart, rightEnd);
    }

    //二叉树结点间最大的距离
    /*
    这个最大距离指，从a到b经过多少个节点，从a到根节点再到b的过程
    or
    1 a，b在root的不同子树
    2 a,b都在左子树
    3 a，b都在右子树

    求有相同父节点的子树的高度和的最大值

    在遍历的过程中收集子树的数据
     */
    public int GetMaxDistance(TreeNode root)
    {
      var max = 0;
      return GetMaxDistance(root, ref max);
    }

    public int GetMaxDistance(TreeNode root, ref int max)
    {
      if (root == null)
      {
        return max;
      }

      var lH = GetMaxDistance(root.left, ref max);

      var rH = GetMaxDistance(root.right, ref max);

      if (lH + rH > max)
      {
        max = lH + rH;
      }
      return lH > rH ? lH + 1 : rH + 1;
    }

    //二叉树中路径和为给定值的所有路径
    /*
    递归
    去掉根节点的值，递归左右
    先序遍历
     */
    public void GetPathWithSum(TreeNode root, int sum, List<TreeNode> list)
    {
      if (root == null)
      {
        return;
      }
      list.Add(root);
      if (root.left == null && root.right == null)
      {
        if (root.val == sum)
        {
          //打印这个list
          printArray(list.ToArray());
          println();
          return;
        }
      }
      else
      {
        GetPathWithSum(root.left, sum - root.val, list);
        GetPathWithSum(root.right, sum - root.val, list);
      }
      list.RemoveAt(list.Count - 1);
    }

    //二叉树的最低公共祖先
    /*

    or
    1 是根节点
    2 在左边
    3 在右边
    递归求解
     */
    public TreeNode GetLowestCommonAncestor(TreeNode root, TreeNode a, TreeNode b)
    {
      if (root == null)
      {
        return null;
      }
      if (a == root || b == root)
      {
        return root;
      }

      var a1 = GetLowestCommonAncestor(root.left, a, b);
      if (a != null)
      {
        return a1;
      }
      return GetLowestCommonAncestor(root.right, a, b);
    }
  }

}
