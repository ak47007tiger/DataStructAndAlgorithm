namespace DataStructure
{

  public class HeapSort
  {
    public int[] Sort(int[] array)
    {
      var maxRootHeap = new ArrayMaxHeap();
      maxRootHeap.Build(array.Length);
      for(var i = 0; i < array.Length; i++){
        maxRootHeap.Insert(array[i]);
      }
      var index = 0;
      while(maxRootHeap.GetSize() > 0){
        array[index] = maxRootHeap.RemoveTop();
        index++;
      }
      return array;
    }
  }

}