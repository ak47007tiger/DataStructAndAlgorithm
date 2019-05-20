using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace LeetCode.Easy {
  /*
  Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

  For example:
  Given binary tree [3,9,20,null,null,15,7],
      3
     / \
    9  20
      /  \
     15   7
  return its bottom-up level order traversal as:
  [
    [15,7],
    [9,20],
    [3]
  ]
   */
  public class BinaryTreeLevelOrderTraversalII {
    /*
    层序遍历，然后反转
    如何确定一层的开始和结束？
      最右边的那个就是结束
      最左边那个是开始
        怎么判断是不是最左边那个？
          某个节点是左节点或者其父节点没有左子树 && 所有的上层节点都是左节点，或者没有左子树
      怎么知道某个节点是第几层的节点？
     */
    /*
    小结
    发现共性，相同的特征
    数据，数据，数据，数据优先，先考虑能获得程序进行下去需要的数据，对象间关系一般能转换成数据
     */
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
      IList<IList<int>> levels = new List<IList<int>>();
      if(root == null){
        return levels;
      }
      Queue<TreeNode> currentNodeQueue = new Queue<TreeNode>();
      Queue<TreeNode> nextLevelNodes = new Queue<TreeNode>();
      currentNodeQueue.Enqueue(root);
      var currentLevel = new List<int>();
      levels.Add(currentLevel);
      var level = 1;
      while(currentNodeQueue.Count > 0){
        var node = currentNodeQueue.Dequeue();
        currentLevel.Add(node.val);
        if(node.left != null){
          nextLevelNodes.Enqueue(node.left);
        }
        if(node.right != null){
          nextLevelNodes.Enqueue(node.right);
        }
        if(currentNodeQueue.Count == 0 && nextLevelNodes.Count > 0){
          //go next layer
          level++;
          currentLevel = new List<int>();
          levels.Add(currentLevel);
          var temp = currentNodeQueue;
          currentNodeQueue = nextLevelNodes;
          nextLevelNodes = temp;
        }
      }

      var array = levels.ToArray();
      for(var i = 0; i < array.Length / 2; i++){
        var to = array.Length - 1 - i;
        var temp = array[to];
        array[to] = array[i];
        array[i] = temp;
      }
      return array;
    }
  }
}