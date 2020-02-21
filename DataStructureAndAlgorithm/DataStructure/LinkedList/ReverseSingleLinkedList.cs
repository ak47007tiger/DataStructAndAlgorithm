namespace DataStructure
{
    public class ReverseSingleLinkedList : BaseSolution
    {
        public ListNode Reverse(ListNode node){
            /*
            如果能画个图就很清晰，代码编辑器应该支持画图类型的注释
            思路
            输入：链表A
            取A的头结点作为链表b的头
            顺序的从A中取头节点作为链表B的头，直到A为空
            */

            var aHead = node.next;
            var bHead = node;
            bHead.next = null;
            
            while(aHead != null){
                var aNext = aHead.next;
                var takkeANode = aHead;
                takkeANode.next = bHead;
                bHead = takkeANode;
                aHead = aNext;
            }
            return bHead;
        }

        public void TestReverse(){
            var list = new SinglyLinkedList();
            list.Add(new ListNode(1));
            list.Add(new ListNode(2));
            list.Add(new ListNode(3));
            list.Add(new ListNode(4));
            list.Add(new ListNode(5));


            var head = list.GetHead();
            while(head != null){
                println(head.val);
                head = head.next;
            }

            head = Reverse(list.GetHead());
            while(head != null){
                println(head.val);
                head = head.next;
            }
        }
        
    }
}