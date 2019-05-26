namespace DataStructure
{
  using System.Collections.Generic;
  public class Node
  {
    public int val;
    public IList<Node> neighbors;

    public Node() { }
    public Node(int _val, IList<Node> _children)
    {
      val = _val;
      neighbors = _children;
    }
  }
}