namespace DataStructure
{

  public class HeapSort
  {
    /*
    使用大根堆或者小根堆排序
    先构建堆，然后不断移除对顶元素并将之放到数组，直到堆空，此时得到一个有序数组
     */
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