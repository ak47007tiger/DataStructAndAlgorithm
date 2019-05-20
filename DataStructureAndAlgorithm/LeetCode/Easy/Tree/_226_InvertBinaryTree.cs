namespace LeetCode
{
  using DataStructure;

  public class InvertBinaryTree
  {
    //todo 非递归way
    /*
    用哪种遍历方式可以
    层序遍历
    先保存每一层，根据这一层获得下一层的对应节点
    需要推演过程，观察是否可行

    层序遍历，反转某一层的队列，开始下一层，可以有null，在这个遍历的过程中生成新的树
    需要保存上一层的节点，根据下标关系1:2，可以计算上一层节点是哪个

    做推演的技巧，画图，状态转移

    遍历过程中如何交换

     */
    public TreeNode InvertTree(TreeNode root)
    {
      if (root == null)
      {
        return null;
      }


      return root;
    }

    public TreeNode InvertTree1(TreeNode root)
    {
      if (root == null)
      {
        return null;
      }

      var lC = root.left;
      var rC = root.right;

      root.left = InvertTree(rC);
      root.right = InvertTree(lC);

      return root;
    }

  }

}
