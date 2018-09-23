using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {

  public class ReverseSingleLinkedList {
    public ListNode Reverse2(ListNode head) {
      if (head == null)return head;
      if (head.next == null)return head;

      var newHead = head;
      var cur = head.next;
      head.next = null;

      while (cur != null) {
        var nextNext = cur.next;
        cur.next = newHead;
        newHead = cur;
        cur = nextNext;
      }
      return newHead;
    }

    public ListNode Reverse1(ListNode head) {
      if (head == null)return head;
      if (head.next == null)return head;

      var next = head.next;
      head.next = null;

      while (next != null) {
        var nextNext = next.next;
        next.next = head;
        head = next;
        next = nextNext;
      }
      return head;
    }
  }

}