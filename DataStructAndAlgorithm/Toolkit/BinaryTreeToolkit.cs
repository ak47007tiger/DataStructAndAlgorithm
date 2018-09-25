using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Toolkit {

  public class BinaryTreeToolkit : BaseSolution {

    public static TreeNode BuildBinarySearchTree(int[] nums) {
      if (nums == null || nums.Length == 0) {
        return null;
      }
      var root = new TreeNode(nums[0]);
      for (var i = 1; i < nums.Length; i++) {
        InsertBinaryTreeNode(root, nums[i]);
      }
      return root;
    }

    public static TreeNode InsertBinaryTreeNode(TreeNode node, int value) {
      if (node == null) { return new TreeNode(value); }
      if (value < node.val) {
        node.left = InsertBinaryTreeNode(node.left, value);
      } else {
        node.right = InsertBinaryTreeNode(node.right, value);
      }
      return node;
    }

    public static TreeNode BuildBalencedBST(int[] nums) {
      return null;
    }

  }

}