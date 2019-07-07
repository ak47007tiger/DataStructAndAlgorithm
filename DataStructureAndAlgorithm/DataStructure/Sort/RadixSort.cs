namespace DataStructure
{
  using System.Collections.Generic;
  /*
  基数排序
  其原理是将整数按位数切割成不同的数字，然后按每个位数分别比较

  将所有待比较数值（正整数）统一为同样的数字长度，数字较短的数前面补零。然后，从最低位开始，依次进行一次排序。
  这样从最低位排序一直到最高位排序完成以后，数列就变成一个有序序列
   */

  public class RadixSort
  {

    public int[] Sort(int[] array)
    {
      //计算是几位数，几位数就排序几次，从低位往高位排序
      var numLength = GetMaxValLength(array);
      for (var i = 0; i < numLength; i++)
      {
        CountSort(array, i);
      }
      return array;
    }

    public int[] CountSort(int[] array, int offset)
    {
      //数字由0-9组成
      var countArray = new int[10];
      //对0-9这些数出现的次数计数
      for (var i = 0; i < array.Length; i++)
      {
        var a = GetVal(array[i], offset);
        countArray[a]++;
      }

      //二次计数，这些值表明之前的数i-1出现的次数加上上当前的数i出现了多少次，这个次数-1就是这个数i对应的在新数组中的index
      for (var i = 1; i < countArray.Length; i++)
      {
        countArray[i] = countArray[i] + countArray[i - 1];
      }

      var b = new int[array.Length];
      for (var i = array.Length - 1; i >= 0; i--)
      {
        //从原始数组中取一个数，转换成0到9之间的数
        var a = GetVal(array[i], offset);
        //这个数在新数组中的位置为：这个数以及这个数之前的数出现的次数 - 1
        b[countArray[a] - 1] = array[i];
        //用掉了一个数，所以计数-1
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
