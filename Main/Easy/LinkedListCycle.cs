using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given a linked list, determine if it has a cycle in it.

Follow up:
Can you solve it without using extra space?
 */

/*
思路
只要head是某个链表的next
方法1
遍历除了第一个外的每个节点，如果该节点的next是head，返回true

更新审题
不一定是头尾的环

思路
遍历链表，当前节点已经在查看过的节点里面，返回ture
从head到当前节点

复习
1 只要从某个节点出发，如果又一次来到这个节点，那么存在环
用hashtable记录每个节点出现的次数，如果>1停止 return true
如果遍历完毕都没有出现>1，return false
 */

namespace LeetCode.Main.Easy {

  public class LinkedListCycle {

    /*
    从前往后遍历，如果一个节点出现2次，那么存在环
     */
    public bool HasCycle(ListNode head) {
      if(head == null) return false;
      if(head.next == null) return false;

      ListNode current = head.next;
      var i = 1;
      while(current != null){
        var ptr = head;
        var j = 1;
        while(ptr.next != current){
          ptr = ptr.next;
          j++;
        }
        if(j < i) return true;
        current = current.next;
        i++;
      }
      return false;
    }

  }

}
