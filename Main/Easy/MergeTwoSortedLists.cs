using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class MergeTwoSortedLists {
    //Definition for singly-linked list.
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }
    public ListNode BuildList(int[] array) {
      ListNode first = new ListNode(array[0]);
      ListNode iter = first;
      for (int i = 1; i < array.Length; i++) {
        iter.next = new ListNode(array[i]);
        iter = iter.next;
      }
      return first;
    }
    public void Print(ListNode node) {
      while (node.next != null) {
        Console.Write(node.val + ",");
        node = node.next;
      }
      Console.WriteLine(node.val);
    }
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
      if (l1 == null && l2 == null)
        return null;
      if (l1 == null)
        return l2;
      if (l2 == null)
        return l1;
      var waitMergeIter = l2;
      var mergedIter = l1;
      ListNode first = l1;
      ListNode mergedIterPrevious = null;
      while (waitMergeIter != null) {
        while (true) {
          if (waitMergeIter.val < mergedIter.val) {
            var insert = waitMergeIter;
            waitMergeIter = waitMergeIter.next;
            insert.next = mergedIter;
            if (mergedIterPrevious == null)
              mergedIterPrevious = insert;
            else {
              mergedIterPrevious.next = insert;
              mergedIterPrevious = insert;
            }
            if (insert.val < first.val)
              first = insert;
            break;
          } else {
            if (mergedIter.next != null) {
              mergedIterPrevious = mergedIter;
              mergedIter = mergedIter.next;
            } else {
              mergedIter.next = waitMergeIter;
              return first;
            }
          }
        }
      }
      return first;
    }
  }
}