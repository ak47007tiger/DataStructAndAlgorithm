namespace DataStructure
{
  /*
  分治法
  
  1 随机找一个值，让要排序的数组范围内的数据比这个值大的放右边，其它放左边
  2 对这个值左边的范围和右边的范围应用操作1

   */
  public class QuickSort
  {
    public int[] Sort(int[] array){
      return Sort(array, 0, array.Length - 1);
    }
    
    //include start and end
    public int[] Sort(int[] array, int start, int end)
    {
      if (start < end)
      {
        var split = Split(array, start, end);
        Sort(array, start, split - 1);
        Sort(array, split + 1, end);
      }
      return array;
    }

    //move 
    public int Split(int[] array, int start, int end)
    {
      var midVal = array[end];
      var i = start;
      var j = end;
      var empPos = end;
      while (i < j)
      {
        //search a val > midVal from start to end
        while (i < j && array[i] <= midVal)
        {
          i++;
        }
        if (i < j)
        {
          array[empPos] = array[i];
          empPos = i;
        }
        //search a val < midVal from end to start
        while (j > i && array[j] >= midVal)
        {
          j--;
        }
        if (j > i)
        {
          array[empPos] = array[j];
          empPos = j;
        }
      }
      array[empPos] = midVal;
      return i;
    }

  }

}
