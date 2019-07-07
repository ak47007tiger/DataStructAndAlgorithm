namespace DataStructure
{
  public class SelectionSort
  {
    /*
    从小到大
    从未排序的序列中选择最小的放到已经排序的序列的后面

    从大到小
    从未排序的序列中选择最大的放到已经排序的序列的后面

    第一趟0个元素被排好，从所有没有排序的元素选最小的放到第一个位置
    第二趟1个元素被排好，从剩下没有排序的元素中找一个最小的放到其后面
    ...
    直到剩下一个元素，此时已经排好序
     */
    public int[] Sort(int[] array)
    {
      //n个元素做n-1趟选择
      for (var i = 0; i < array.Length - 1; i++)
      {
        //从未排序的部分找到最小的那个元素
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