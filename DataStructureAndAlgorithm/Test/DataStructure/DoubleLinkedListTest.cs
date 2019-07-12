namespace DataStructure
{

  public class DoubleLinkedListTest : BaseSolution
  {

    public void SimpleTest()
    {
      var list = new DoubleLinkedList();
      println(list.IsEmpty());

      list.Add(new DoubleListNode(1));

      println(list.IsEmpty());

      list.Add(new DoubleListNode(2));
      println(list.Size());

      println(list.Get(1).val);

      list.Remove(list.Get(0));
      println(list.Size());

      list.Add(new DoubleListNode(3));
      list.Add(new DoubleListNode(4), 1);

      println(list.Get(list.Size() - 2).val);

      list.Clear();
      println(list.IsEmpty());
    }

  }

}
