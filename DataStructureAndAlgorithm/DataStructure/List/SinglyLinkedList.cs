/*
单向链表（又名单链表、线性链表）是链表的一种，其特点是链表的链接方向是单向的，对链表的访问要通过从头部开始，依序往下读取。
 */

namespace DataStructure
{

  public class SinglyLinkedList
  {
    ListNode head;

    public bool IsEmpty()
    {
      return head == null;
    }

    public void Clear()
    {
      head = null;
    }

    public ListNode GetParent(ListNode node)
    {
      if (head == null)
      {
        return null;
      }

      var cur = head;
      while (cur != null && cur.next != node)
      {
        cur = cur.next;
      }

      return cur;
    }

    public int IndexOf(ListNode node)
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

    public void Add(ListNode node, int index)
    {
      var target = Get(index);
      Remove(target);
      Add(node);
      Add(target);
    }

    public void Add(ListNode node)
    {
      if (head == null)
      {
        head = node;
        return;
      }
      //追加到末尾
      var cur = head;
      while (cur.next != null)
      {
        cur = cur.next;
      }
      cur.next = node;
    }

    public void Remove(ListNode node)
    {
      if (head == null)
      {
        return;
      }

      if (head == node)
      {
        if (head.next != null)
        {
          head = head.next;
        }
        else
        {
          head = null;
        }
        return;
      }

      //找到node前一个、node
      var parent = GetParent(node);
      //can not find node
      if (parent == null)
      {
        return;
      }
      parent.next = node.next;
    }

    public ListNode Get(int index)
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

    public int Size()
    {
      var temp = head;
      var count = 0;

      while (temp != null)
      {
        count++;
        temp = temp.next;
      }
      return count;
    }

  }

}
