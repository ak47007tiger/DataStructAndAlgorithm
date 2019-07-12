namespace DataStructure
{

  public class CircularLinkedListTest : BaseSolution
  {

    public void SimpleTest()
    {
      var list = new CircularLinkedList();
      println(list.GetLast());//null
      println(list.Size());//0
      list.Add(new ListNode(1));
      var node2 = new ListNode(2);
      list.Add(node2);
      list.Add(new ListNode(3));
      println(list.Get(2).val);//3
      println(list.IndexOf(node2));//1
      list.Remove(node2);
      println(list.Get(0).val);//1
      println(list.Get(1).val);//3
      println(list.GetLast().val);//3
    }

  }

}
