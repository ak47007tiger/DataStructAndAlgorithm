namespace DataStructure
{
  /*
  分治法
  
  1 随机找一个值，让要排序的数组范围内的数据比这个值大的放右边，其它放左边
  2 对这个值左边的范围和右边的范围应用操作1

   */
  public class QuickSort
  {
    public int[] Sort(int[] array)
    {
      return Sort(array, 0, array.Length - 1);
    }

    //include start and end
    public int[] Sort(int[] array, int start, int end)
    {
      //数组无法再分割，此时结束
      //一段数据不能分割表明该段数据已经排序完成，又因为每段数据都是按照从小到大放置的，故所有数据排序完成
      if (start < end)
      {
        //分割数组，小的在左边，大的在右边
        var split = Split2(array, start, end);
        //对分割的数组递归调用快速排序
        //当数组无法分割的时候，相当于2个数据被排好序了
        //当数组能分割，说明2段数据已经分大小了
        Sort(array, start, split - 1);
        Sort(array, split + 1, end);
      }
      return array;
    }

    /*
    这个分割函数更加好理解，先把元素分类，然后按照类别逐个放到原始数组对应的数据段
    这个分类函数消耗更多内存
     */
    public int Split2(int[] array, int start, int end)
    {
      var smallBuf = new int[end - start];
      var smallCnt = 0;
      var bigBuf = new int[end - start];
      var bigCnt = 0;
      var midVal = array[end];

      for (var i = start; i < end; i++)
      {
        if (array[i] < midVal)
        {
          smallBuf[smallCnt] = array[i];
          smallCnt++;
        }
        else
        {
          bigBuf[bigCnt] = array[i];
          bigCnt++;
        }
      }

      var j = start;
      for (var i = 0; i < smallCnt; i++)
      {
        array[j] = smallBuf[i];
        j++;
      }
      array[j] = midVal;
      j++;
      for (var i = 0; i < bigCnt; i++)
      {
        array[j] = bigBuf[i];
        j++;
      }
      return start + smallCnt;
    }

    public int Split3(int[] array, int start, int end)
    {
      var smallBuf = new int[end - start];
      var smallCnt = 0;
      var bigBuf = new int[end - start];
      var bigCnt = 0;
      var midVal = array[end];

      for (var i = start; i < end; i++)
      {
        if (array[i] < midVal)
        {
          smallBuf[smallCnt] = array[i];
          smallCnt++;
        }
        else
        {
          bigBuf[bigCnt] = array[i];
          bigCnt++;
        }
      }

      for (var i = 0; i < end - start + 1; i++)
      {
        if (i < smallCnt)
        {
          array[start + i] = smallBuf[i];
          continue;
        }
        if (i == smallCnt)
        {
          array[start + i] = midVal;
          continue;
        }
        var big = bigBuf[i - smallCnt - 1];
        array[start + i] = big;
      }
      return start + smallCnt;
    }

    /*
    分割一个数据段，在数据段中找一个值，这里我们之间用数据段中最后那个值
    把比这个值小的放这个值前面
    把比这个值大的放这个值后面
     */
    public int Split(int[] array, int start, int end)
    {
      var midVal = array[end];
      var i = start;
      var j = end;
      //第一个空位
      var empPos = end;
      //不断的找，直到所有数据都被分类成大或者小
      while (i < j)
      {
        //search a val > midVal from start to end
        //从前往后找到比中值大的
        while (i < j && array[i] <= midVal)
        {
          i++;
        }
        //找到了，换到空位上，此时小的部分空出一个位置，更新空位
        if (i < j)
        {
          array[empPos] = array[i];
          empPos = i;
        }
        //search a val < midVal from end to start
        //从后往前找一个比中值小的
        while (j > i && array[j] >= midVal)
        {
          j--;
        }
        //找到了，换到空位上，此时大的部分空出一个位置，更新空位
        if (j > i)
        {
          array[empPos] = array[j];
          empPos = j;
        }
      }
      //最后的空位正好用来放中值，因为能跳出循环说明所有的元素都遍历到了，小的都在左边，大的都在右边
      array[empPos] = midVal;
      return i;
    }

  }

}
