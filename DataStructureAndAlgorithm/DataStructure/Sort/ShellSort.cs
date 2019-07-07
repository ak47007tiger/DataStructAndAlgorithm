namespace DataStructure
{

  public class ShellSort
  {
    /*
    - 插入排序在对几乎已经排好序的数据操作时，效率高，即可以达到线性排序的效率
    - 插入排序一般来说是低效的，因为插入排序每次只能将数据移动一位

    - 步长影响排序效率

    先用大的步长排序，逐渐缩小步长
    最后会变成插入排序
     */
    public int[] Sort(int[] array)
    {
      var step = array.Length / 2;
      //每一个不同的步长是一组数据
      while (step > 0)
      {
        //使用步长把数据分组，对这一组数据进行插入排序
        for (var i = step; i < array.Length; i += step)
        {
          var temp = array[i];
          for (var j = i - step; j >= 0; j -= step)
          {
            if (array[j] > temp)
            {
              array[j + step] = array[j];
              array[j] = temp;
            }
            else
            {
              break;
            }
          }
        }

        step = step / 2;
      }
      return array;
    }

  }

}
