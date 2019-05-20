using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace NiuKeWang
{
  public class BreadthFirstTravelTree : BaseSolution
  {
    /*
    当前从队列中取出的那一个是上一层最后放进去的那一个的时候
    表明达到一层的末尾，开始下一层了
     */
    public void Travel1(TreeNode node)
    {
      if (node == null)
      {
        return;
      }
      TreeNode levelLastNode = node;
      var queue = new Queue<TreeNode>();
      queue.Enqueue(node);
      var level = 1;
      println(level + ":");
      while (queue.Count > 0)
      {
        var front = queue.Dequeue();
        print(front.val);
        print(',');
        if (front.left != null)
        {
          queue.Enqueue(front.left);
        }
        if (front.right != null)
        {
          queue.Enqueue(front.right);
        }
        //a level end
        if (levelLastNode == front && queue.Count > 0)
        {
          levelLastNode = queue.Last();
          level++;
          println();
          println(level + ":");
        }
      }
    }
  }
}