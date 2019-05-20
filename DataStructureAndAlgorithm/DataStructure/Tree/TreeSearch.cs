using System.Linq;
using System.Collections.Generic;
namespace DataStructure
{

  public class TreeSearch : BaseSolution
  {

    public void BreadthFirstSearch(TreeNode root)
    {
      if (root == null)
      {
        return;
      }

      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      while (queue.Count > 0)
      {
        var node = queue.Dequeue();
        print(node.val);
        print(',');
        if (null != node.left)
        {
          queue.Enqueue(node.left);
        }
        if (null != node.right)
        {
          queue.Enqueue(node.right);
        }
      }

    }

    /*
    观察入队的过程，每当访问到某一层最后一个节点，并且入队其子节点后，此时队列的最后一个是下一层的最后一个节点，这个时候处理并输出layer信息，还可以更新最后一层的节点
    第一层的节点是已知的，那么第二层也可以获得，后续的都可以获得

     */
    public void BreadthFirstSearchWithLayerNo(TreeNode root)
    {
      if (root == null)
      {
        return;
      }

      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);
      TreeNode layerLast = root;
      var layer = 1;
      print(layer);
      println();
      while (queue.Count > 0)
      {
        var node = queue.Dequeue();

        print(node.val);
        print(',');

        if (null != node.left)
        {
          queue.Enqueue(node.left);
        }
        if (null != node.right)
        {
          queue.Enqueue(node.right);
        }

        if (node == layerLast && queue.Count > 0)
        {
          layerLast = queue.Last();
          layer++;
          print(layer);
          println();
        }
      }

    }

    //相当于前、中、后序遍历
    public void DepthFirstSearch(TreeNode root)
    {
      if (root == null)
      {
        return;
      }

      print(root.val);

      print(',');

      DepthFirstSearch(root.left);
      DepthFirstSearch(root.right);

    }

  }

}
