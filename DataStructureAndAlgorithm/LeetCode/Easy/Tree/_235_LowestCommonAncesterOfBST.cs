using System;
namespace LeetCode
{
  using DataStructure;
  /*
  最低公共祖先
  1 p,q分别在root的左右
  2 p,q都在rootroot的左或右，转换成1
  3 p是q或者q是p的父节点
   */
  public class LowestCommonAncesterOfBST
  {

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
      if(root == null || p == null || q == null){
        return null;
      }
      if(root == p || root == q){
        return root;
      }

      //p,q all are in left
      if(root.val > Math.Max(p.val, q.val)){
        return LowestCommonAncestor(root.left, p,q);
      }
      //p,q all are in right
      if(root.val < Math.Max(p.val, q.val)){
        return LowestCommonAncestor(root.right, p,q);
      }

      return root;
    }



  }

}