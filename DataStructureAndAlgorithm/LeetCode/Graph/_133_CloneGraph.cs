using System.Collections.Generic;
namespace DataStructure
{
  /*
  Given a reference of a node in a connected undirected graph, return a deep copy (clone) of the graph. 
  Each node in the graph contains a val (int) and a list (List[Node]) of its neighbors.
   */

  /*
  把所有的节点和节点间的关系复制下来
  创建所有的节点，建立原节点和新节点间的映射
  遍历所有的节点，逐个复制这些节点的关系
   */
  public class CloneGraphCls
  {

    public Node CloneGraph(Node node)
    {
      //广度优先方式遍历所有节点 制作映射关系
      /*
      1个字典 做映射
      1个字典 做hash判断是否处理过
       */
      var dic = new Dictionary<Node, Node>();
      CollectAllNodes(dic, node);
      var set = new HashSet<Node>();
      foreach (var item in dic)
      {
        var key = item.Key;
        var val = item.Value;
        var list = new List<Node>();
        for (var i = 0; i < key.neighbors.Count; i++)
        {
          list.Add(dic[key.neighbors[i]]);
        }
        val.neighbors = list;
      }
      return dic[node];
    }

    public void CollectAllNodes(Dictionary<Node, Node> dic, Node node)
    {
      if (dic.ContainsKey(node))
      {
        return;
      }

      var cloneNode = new Node();
      cloneNode.val = node.val;
      dic.Add(node, cloneNode);

      foreach (var item in node.neighbors)
      {
        CollectAllNodes(dic, item);
      }

    }

  }

}
