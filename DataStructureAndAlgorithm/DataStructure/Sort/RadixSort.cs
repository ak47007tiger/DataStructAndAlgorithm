namespace DataStructure
{
  using System.Collections.Generic;
  /*
  其原理是将整数按位数切割成不同的数字，然后按每个位数分别比较

  将所有待比较数值（正整数）统一为同样的数字长度，数字较短的数前面补零。然后，从最低位开始，依次进行一次排序。
  这样从最低位排序一直到最高位排序完成以后，数列就变成一个有序序列
   */

  public class RadixSort
  {

    public int[] Sort(int[] array)
    {
      var numLength = GetMaxValLength(array);
      for (var i = 0; i < numLength; i++)
      {
        CountSort(array, i);
      }
      return array;
    }

    public int[] CountSort(int[] array, int offset)
    {
      var maxVal = Toolkit.MathEx.Max(array);
      var countArray = new int[10];

      for (var i = 0; i < array.Length; i++)
      {
        var a = GetVal(array[i], offset);
        countArray[a]++;
      }

      for (var i = 1; i < countArray.Length; i++)
      {
        countArray[i] = countArray[i] + countArray[i - 1];
      }

      var b = new int[array.Length];
      for (var i = array.Length - 1; i >= 0; i--)
      {
        var a = GetVal(array[i], offset);
        b[countArray[a] - 1] = array[i];
        countArray[a]--;
      }

      for (var i = 0; i < array.Length; i++)
      {
        array[i] = b[i];
      }

      return array;
    }

    //个位 offset = 0， 十位 offset = 1
    public static int GetVal(int val, int offset)
    {
      var devide = 1;
      for (var i = 0; i < offset; i++)
      {
        devide *= 10;
      }
      return val / devide % 10;
    }

    public static int GetMaxValLength(int[] array)
    {
      var max = array[0];
      for (var i = 0; i < array.Length; i++)
      {
        max = System.Math.Max(array[i], max);
      }
      return max.ToString().Length;
    }

  }

}
