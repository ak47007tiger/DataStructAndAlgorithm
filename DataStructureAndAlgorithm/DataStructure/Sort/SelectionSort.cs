namespace DataStructure
{
  public class SelectionSort
  {
    /*
    从小到大
    从未排序的序列中选择最小的放到已经排序的序列的后面

    从大到小
    从未排序的序列中选择最大的放到已经排序的序列的后面
     */
    public int[] Sort(int[] array)
    {
      for (var i = 0; i < array.Length - 1; i++)
      {
        var minValIndex = i;
        for (var j = i + 1; j < array.Length; j++)
        {
          if (array[j] < array[minValIndex])
          {
            minValIndex = i;
          }
        }
        //swap
        var temp = array[i];
        array[i] = array[minValIndex];
        array[minValIndex] = temp;
      }
      return array;
    }

  }
}