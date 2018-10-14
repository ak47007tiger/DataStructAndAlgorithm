using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace LeetCode.Easy {

  /*
  Given a sorted linked list, delete all duplicates such that each element appear only once.

Example 1:

Input: 1->1->2
Output: 1->2
Example 2:

Input: 1->1->2->3->3
Output: 1->2->3
   */
  public class RemoveDuplicatesFromSortedList {
      /*
      1 从第一个起
      2 逐个跟后面的比较，如果后面有重复的，删除后面那个，直到所有跟当前元素重复的元素都被删除
      3 下一个，重复2，直到没有后继结点
       */
    public ListNode DeleteDuplicates(ListNode head) {
      ListNode current = head;
      while(current != null){
        ListNode comparePrevious = current;
        ListNode compare = current.next;
        while(compare != null){
          if(compare.val == current.val){
            comparePrevious.next = compare.next;
            compare = comparePrevious.next;
          }else{
            comparePrevious = compare;
            compare = comparePrevious.next;
          }
        }
        current = current.next;
      }
      return head;
    }
  }
}