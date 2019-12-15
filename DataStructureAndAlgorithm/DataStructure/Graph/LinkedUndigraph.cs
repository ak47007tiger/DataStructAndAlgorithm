using System.Collections.Generic;
namespace DataStructure
{

  public class LinkedUndigraph : BaseSolution
  {
    HashSet<int> valueSet = new HashSet<int>();
    Dictionary<int, Node> valToNode = new Dictionary<int, Node>();
    List<Node> vertexes = new List<Node>();

    public void Add(int a, int b)
    {
      /*
      如果没有这个顶点，增加顶点
      增加边
       */
      Add(a);
      Add(b);
      var nodeA = Get(a);
      var nodeB = Get(b);
      if (!nodeA.neighbors.Contains(nodeB))
      {
        nodeA.neighbors.Add(nodeB);
      }
      if (!nodeB.neighbors.Contains(nodeA))
      {
        nodeB.neighbors.Add(nodeA);
      }
    }

    public void Add(int a)
    {
      if (Contains(a))
      {
        return;
      }

      valueSet.Add(a);
      var node = new Node(a, new List<Node>());
      valToNode.Add(a, node);
      vertexes.Add(node);
    }

    public bool Contains(int val)
    {
      return valueSet.Contains(val);
    }

    public void Remove(int a)
    {
      /*
      删除边，在所有的顶点中查找包含顶点a的边
      删除顶点
      删除关系数据
       */
      var node = Get(a);
      if (node == null)
      {
        return;
      }
      foreach (var aNode in vertexes)
      {
        aNode.neighbors.Remove(node);
      }
      valueSet.Remove(a);
      valToNode.Remove(a);
      vertexes.Remove(node);
    }

    public Node Get(int value)
    {
      Node node;
      if (valToNode.TryGetValue(value, out node))
      {
        return node;
      }
      return null;
    }

    public void Create(int[][] input)
    {
      /*
      找到所有节点
      建立节点关系映射
      建立图
       */
      for (var i = 0; i < input.Length; i++)
      {
        var kv = input[i];
        valueSet.Add(kv[0]);
        valueSet.Add(kv[1]);
      }

      var enumerator = valueSet.GetEnumerator();
      while (enumerator.MoveNext())
      {
        var node = new Node(enumerator.Current, new List<Node>());
        valToNode.Add(enumerator.Current, node);
        vertexes.Add(node);
      }

      for (var i = 0; i < input.Length; i++)
      {
        var kv = input[i];
        var node = valToNode[kv[0]];
        var neighbor = valToNode[kv[1]];
        //无向图 双向都加
        node.neighbors.Add(neighbor);
        neighbor.neighbors.Add(node);
      }
    }

    public void Print()
    {
      foreach (var node in vertexes)
      {
        foreach (var neighbor in node.neighbors)
        {
          println(node.val + " -> " + neighbor.val);
        }
      }
    }

  }

}
