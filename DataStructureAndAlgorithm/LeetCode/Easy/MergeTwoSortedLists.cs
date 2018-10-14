using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace LeetCode.Easy {
  public class MergeTwoSortedLists {
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