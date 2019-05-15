namespace DataStructure
{

  public class MergeSort
  {

    public int[] Sort(int[] array)
    {
      return Sort(array, 0, array.Length - 1);
    }

    //include from and to
    public int[] Sort(int[] array, int from, int to)
    {
      if (from < to)
      {
        var mid = (from + to) / 2;
        Sort(array, from, mid);
        Sort(array, mid + 1, to);
        Merge2(array, from, mid, to);
      }
      return array;
    }

    public void Merge(int[] array, int from, int mid, int to)
    {
      var tempArray = new int[to - from + 1];
      var indexA = from;
      var indexB = mid + 1;
      var indexTemp = 0;

      while (indexA <= mid && indexB <= to)
      {
        if (array[indexA] < array[indexB])
        {
          tempArray[indexTemp] = array[indexA];
          indexA++;
        }
        else
        {
          tempArray[indexTemp] = array[indexB];
          indexB++;
        }
        indexTemp++;
      }

      while (indexA <= mid)
      {
        tempArray[indexTemp] = array[indexA];
        indexTemp++;
        indexA++;
      }

      while (indexB <= to)
      {
        tempArray[indexTemp] = array[indexB];
        indexTemp++;
        indexB++;
      }

      for (var i = from; i <= to; i++)
      {
        array[i] = tempArray[i - from];
      }
    }

    public void Merge2(int[] array, int from, int mid, int to)
    {
      for (var i = mid + 1; i <= to; i++)
      {
        var temp = array[i];
        for (var j = i - 1; j >= from; j--)
        {
          if (temp < array[j])
          {
            array[j + 1] = array[j];
            array[j] = temp;
          }
          else
          {
            break;
          }
        }
      }
    }

    public void TestMerge()
    {
      var array = new int[] { 3, 4, 9, 1, 2, 7 };
      Merge(array, 0, 2, array.Length - 1);
      BaseSolution.printArray(array);
    }

    public void TestMerge2()
    {
      var array = new int[] { 3, 4, 9, 1, 2, 7 };
      Merge2(array, 0, 2, array.Length - 1);
      BaseSolution.printArray(array);
    }

  }

}