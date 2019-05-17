namespace DataStructure
{
  using System.Collections.Generic;

  /*
  一般桶排序：区间桶
  当数据量很大，数据非常离散，无法一次性分配出巨大的桶数组，此时用区间桶
  区间里面放列表，单独对列表排序，然后收集
   */

  public class BucketSort
  {

    public int[] UniverseSort(int[] array)
    {
      var max = Toolkit.Math.Max(array);
      //分区间
      var hashVal = 10;
      var bucketSize = System.Math.Max(max / hashVal, 1);
      var buckets = new List<int>[bucketSize];

      for (var i = 0; i < buckets.Length; i++)
      {
        buckets[i] = new List<int>();
      }

      for (var i = 0; i < array.Length; i++)
      {
        var bucketIndex = System.Math.Max((array[i] / hashVal), 1) - 1;
        buckets[bucketIndex].Add(array[i]);
      }

      var sortFunc = new MergeSort();

      var index = 0;
      for(var i = 0; i < buckets.Length; i++){
        var list = buckets[i];
        var childArray = sortFunc.Sort(list.ToArray());
        for(var j = 0; j < childArray.Length; j++){
          array[index] = childArray[j];
          index++;
        }
      }

      return array;
    }

    public int[] Sort(int[] array)
    {
      var max = array[0];
      for (var i = 1; i < array.Length; i++)
      {
        max = System.Math.Max(max, array[i]);
      }

      var countArray = new int[max + 1];
      for (var i = 0; i < array.Length; i++)
      {
        countArray[array[i]]++;
      }

      var index = 0;
      for (var i = 0; i < countArray.Length; i++)
      {
        for (var j = 0; j < countArray[i]; j++)
        {
          array[index] = i;
          index++;
        }
      }

      return array;
    }

  }

}
