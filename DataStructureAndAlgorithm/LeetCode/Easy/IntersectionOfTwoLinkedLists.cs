using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Write a program to find the node at which the intersection of two singly linked lists begins.


For example, the following two linked lists:

A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
begin to intersect at node c1.


Notes:

If the two linked lists have no intersection at all, return null.
The linked lists must retain their original structure after the function returns.
You may assume there are no cycles anywhere in the entire linked structure.
Your code should preferably run in O(n) time and use only O(1) memory.
Credits:
Special thanks to @stellari for adding this problem and creating all test cases.
 */
/*
审题
题目没有说都是null的情况，预设null
题目没有说a,b的数值都一样的情况，预设null

找到2个链表里面第一个相同数值的节点并且后续节点值也相同
思路1
从后往前找能找到相同的，return true
最后一个是否相同，倒数第二个是否相同
先确定个数，在从后往前回溯
思路2
在a中是否能找到一个节点的数值和b中某个节点是一样大的，并且后续的节点对应的值都是一样大的
遍历a的同时遍历b

看了答案
这道题在问，2个链表是否有相同值的节点

[1,9,8,3,4,6]
[5,0,2,4,6]
 */
namespace LeetCode.Easy {

  public class IntersectionOfTwoLinkedLists {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
      if (headA == null && headB == null) return null;
      HashSet<int> set = new HashSet<int>();
      var temp = headA;
      while (temp != null) {
        set.Add(temp.val);
        temp = temp.next;
      }
      temp = headB;
      while (temp != null) {
        if (set.Contains(temp.val)) return temp;
        temp = temp.next;
      }
      return null;
    }

  }
}