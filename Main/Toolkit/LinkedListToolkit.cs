namespace LeetCode.Main.Toolkit {
  public class LinkedListToolkit {
    public static void PrintLinkedList(ListNode head) {
      var cur = head;
      Printer.print('[');
      while (cur != null) {
        Printer.print(cur.val);
        cur = cur.next;
        if (cur != null) {
          Printer.print(',');
        }
      }
      Printer.print(']');
    }

    public static ListNode BuildSingleLinkedList(int[] array) {
      if (array == null || array.Length == 0)return null;
      if (array.Length == 1)return new ListNode(array[0]);

      var head = new ListNode(array[0]);
      var cur = head;
      for (var i = 1; i < array.Length; i++) {
        cur.next = new ListNode(array[i]);
        cur = cur.next;
      }
      return head;
    }

  }
}