namespace LeetCode
{
  using DataStructure;
  public class _236_LowestCommonAncestorOfBT
  {
    /*
    最低公共祖先
    1 p,q分别在root的左右
    2 p,q都在rootroot的左或右，转换成1
    3 p是q或者q是p的父节点
     */
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
      if (root == null || p == null || q == null)
      {
        return null;
      }

      if (root.val == p.val)
      {
        //在root的左右子树查找q，如果能查到返回root
        if (Contains(root.left, q) || Contains(root.right, q))
        {
          return root;
        }
        return null;
      }
      if (root.val == q.val)
      {
        if (Contains(root.left, p) || Contains(root.right, p))
        {
          return root;
        }
        return null;
      }

      var pL = LowestCommonAncestor(root.left, p, q);
      if (pL != null)
      {
        return pL;
      }

      var pR = LowestCommonAncestor(root.right, p, q);
      if (pR != null)
      {
        return pR;
      }

      if(Contains(root,p) && Contains(root, q)){
        return root;
      }

      return null;

    }

    public bool Contains(TreeNode root, TreeNode target)
    {
      if (root == null)
      {
        return false;
      }
      if (root.val == target.val)
      {
        return true;
      }
      return Contains(root.left, target) || Contains(root.right, target);
    }

  }

}

/*

1
2,3
null,4

 */
