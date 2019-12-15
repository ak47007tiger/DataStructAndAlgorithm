namespace DataStructure
{

  public class ArrayBinaryTreeTest : BaseSolution
  {

    public void SimpleTest()
    {
      println(ArrayBinarySearchTree.GetParentIndex(4));//1
      println(ArrayBinarySearchTree.GetLeftChildIndex(4));//9
      println(ArrayBinarySearchTree.GetRightChildIndex(4));//10

      var tree = new ArrayBinarySearchTree(new int[]{3,4,8,6,2,1,19});

      println(tree.Find(3).val);
      println(tree.Find(8).val);
      println(tree.Find(1).val);

      println(tree.FindIndex(3));//0
      println(tree.FindIndex(8));//6
      println(tree.FindIndex(1));//3
    }

  }

}
