using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  /*
  Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

  For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

      1
     / \
    2   2
   / \ / \
  3  4 4  3
  But the following [1,2,2,null,3,null,3] is not:
      1
     / \
    2   2
     \   \
     3    3
  Note:
  Bonus points if you could solve it both recursively and iteratively.
    */
  public class SymmetricTree {
    /*
    对称的特征：如果有坐标的话，就是x反过来
    在数组上的体现：从第二层开始，正着数和反着数获得的值相同
    1 层序遍历
    2 递归
    3 二叉树每层的数量特征
    1,2,4,8,16,32...(2 的 (层 -1)次方)
    0,1~2,3~6...(startN = startN-1 + countN-1, endN = endN-1 + countN-1)
     */

    /*
    看了参考之后的小结
    处理问题前需要仔细观察思考规律
    1 先掌握获得规律的方法
    2 熟练使用获取规律的方法
    一旦完成1,2就只要尽量多的了解更多的规律和典型的使用方法
    再去自己发现规律就很浪费时间，共享发现的规律更好
      */

    public bool IsSymmetric(TreeNode root){
      return IsMirror(root, root);
    }

    bool IsMirror(TreeNode node1, TreeNode node2){
      if(node1 == null && node2 == null) return true;
      if(node1 == null || node2 == null) return false;
      return node1.val == node2.val && IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
    }

    public bool IsSymmetric1(TreeNode root) {
      List<TreeNode> list = new List<TreeNode>();
      Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
      nodeQueue.Enqueue(root);
      while (nodeQueue.Count > 0) {
        var node = nodeQueue.Dequeue();
        list.Add(node);
        if (node != null) {
          if (node.left != null || node.right != null) {
            nodeQueue.Enqueue(node.left);
            nodeQueue.Enqueue(node.right);
          }
        }
      }

      var count = list.Count;
      var h = 1;
      var total = 1;
      var stack = new Stack<TreeNode>();
      while (total < count) {
        var countH = (int) Math.Pow(2, h);
        var start = total;
        var end = start - 1 + countH;
        int mid = (start + end) / 2;
        stack.Clear();
        for (var j = start; j <= mid; j++) {
          stack.Push(list[j]);
        }
        for (var j = mid + 1; j <= end; j++) {
          var top = stack.Peek();
          //both is null
          if (top == list[j]) {
            stack.Pop();
          }
          if (top != null && list[j] != null && top.val == list[j].val) {
            stack.Pop();
          }
        }
        if (stack.Count > 0) {
          return false;
        }

        total += countH;
        h++;
      }
      return true;
    }

    /*
        for (var j = start; j <= mid; j++) {
          var f = list[j];
          TreeNode b = list[end - (j - start)];
          if (f == b) {
            //f and b (is null) or (not null and same)
            continue;
          }
          //f != b
          if(f == null || b == null){
            return false;
          }
          if(f.val != b.val){
            return false;
          }
        }
     */

    public TreeNode Build(object[] array) {
      var total = 1;
      var count = array.Length;
      var root = new TreeNode((int) array[0]);
      while (total < count) {

      }
      return root;
    }

    public static TreeNode TestData1() {
      //[2,3,3,4,5,5,4,null,null,8,9,9,8]
      /*
      2
      3,3
      4,5,5,4
      null,null,8,9,9,8
       */
      return null;
    }

    public int ComputeHeight(int count) {
      var height = 0;
      while (count > 0) {
        count -= (int) Math.Pow(2, height);
        height++;
      }
      return height;
    }

    /*
    
      var start = 0;
      var end = 0;
      for(var i = 1; i <= height; i++){
        start = end + 1;
        end = end + (int)Math.Pow(2,i);
        int mid = (start + end) / 2;
        for(var j = 0; j <= mid; j++){

        }
      }
     */

    List<TreeNode> BreadthFirstSearch(TreeNode root) {
      List<TreeNode> list = new List<TreeNode>();
      Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
      nodeQueue.Enqueue(root);
      while (nodeQueue.Count > 0) {
        var node = nodeQueue.Dequeue();
        list.Add(node);
        if (node != null) {
          if (node.left != null || node.right != null) {
            nodeQueue.Enqueue(node.left);
            nodeQueue.Enqueue(node.right);
          }
        }
      }
      return list;
    }

    int GetHeight(TreeNode root) {
      return 0;
    }

    TreeNode GetNode(TreeNode root, int layer, int index) {
      //
      return null;
    }
  }
}