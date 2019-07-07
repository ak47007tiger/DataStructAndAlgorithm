namespace DataStructure
{
  public class BubbleSort
  {
    /*
    冒泡排序
    两次for循环，把小的往后面放
     */
    public int[] Sort(int[] array)
    {
      for (var i = 0; i < array.Length - 1; i++)
      {
        for (var j = 0; j < array.Length - 1; j++)
        {
          if (array[j] < array[j + 1])
          {
            var temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
          }
        }
      }
      return array;
    }

    /*
    优化的冒泡，因为第1趟已经把最小的放到最后了，那么第二趟最后一个元素不需要排序
     */
    public int[] Sort2(int[] array)
    {
      for (var i = 0; i < array.Length - 1; i++)
      {
        for (var j = 0; j < array.Length - 1 - i; j++)
        {
          if (array[j] < array[j + 1])
          {
            var temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
          }
        }
      }
      return array;
    }

    public int[] Sort(int[] array, int start, int end)
    {

      return array;
    }
  }
}