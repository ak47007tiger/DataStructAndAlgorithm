/*
有前驱和后继的链表
 */

namespace DataStructure
{
  public class DoubleLinkedList
  {

    public DoubleListNode head;

    public bool IsEmpty()
    {
      return head == null;
    }

    public DoubleListNode GetParent(DoubleListNode node)
    {
      return node.pre;
    }

    public int Size()
    {
      var cur = head;
      var count = 0;
      while (cur != null)
      {
        count++;
        cur = cur.next;
      }
      return count;
    }

    public void Clear()
    {
      head = null;
    }

    public void Add(DoubleListNode node)
    {
      if (null == head)
      {
        head = node;
        return;
      }

      var parent = GetLastNode();
      parent.next = node;
      node.pre = parent;
    }

    public DoubleListNode GetLastNode()
    {
      var cur = head;
      while (cur.next != null)
      {
        cur = cur.next;
      }
      return cur;
    }

    public void Add(DoubleListNode node, int index)
    {
      var target = Get(index);
      var parent = target.pre;
      parent.next = node;
      node.pre = parent;
      
      node.next = target;
      target.pre = node;
    }

    public void RemoveAllFrom(DoubleListNode node){
      var parent = GetParent(node);
      parent.next = null;
    }

    private void SetParentChild(DoubleListNode parent, DoubleListNode child)
    {
      parent.next = child;
      child.pre = parent;
    }

    public void Remove(DoubleListNode node)
    {
      if (node == head)
      {
        if (head.next == null)
        {
          head = null;
        }
        else
        {
          head = head.next;
          head.pre = null;
        }
        return;
      }

      var parent = node.pre;
      var child = node.next;

      parent.next = child;
      child.pre = parent;
    }

    public DoubleListNode Get(int index)
    {
      if (null == head)
      {
        throw new System.Exception("empty list");
      }

      //计数，需要找多少次
      var count = index + 1;
      var temp = head;
      var c = 1;
      while (c < count && temp != null)
      {
        temp = temp.next;
        c++;
      }

      //计数不够，index超了
      if (c < count)
      {
        throw new System.IndexOutOfRangeException(string.Format("index:{0}", index));
      }

      return temp;
    }

    public int IndexOf(DoubleListNode node)
    {
      if (head == null)
      {
        return -1;
      }
      var cur = head;
      var i = 0;
      while (cur != null && cur != node)
      {
        cur = cur.next;
        i++;
      }
      if (cur == null)
      {
        return -1;
      }
      return i;
    }

  }
}
