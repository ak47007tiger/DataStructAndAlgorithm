/*
计数排序使用一个额外的数组 {\displaystyle C}  C ，其中第i个元素是待排序数组 {\displaystyle A} A中值等于 {\displaystyle i} i的元素的个数。然后根据数组 {\displaystyle C}  C 来将 {\displaystyle A} A中的元素排到正确的位置。
 */

/*
输入：A
新建数组B
新建数组C，用index代表value，C[index] = value频率
index in 0 to C.length - 1
C[index] = C[index] + C[index-1]
这个操作是求算A[index]在新的数组B中的index, 包括数组中有重复的数的情况
index in 0 to A.length - 1
B[ C[ A[ index ] - min ] ] = A[ index ]
//C中index减小，代表下一个放入B中的数在B中的index
C[ A[ index ] - min ] --
 */

namespace DataStructure
{
  public class CountSort
  {
    public static int[] countingSort(int[] A)
    {
      int[] B = new int[A.Length];
      // 假设A中的数据a'有，0<=a' && a' < k并且k=100
      int k = 100;
      countingSort(A, B, k);
      return B;
    }

    private static void countingSort(int[] A, int[] B, int k)
    {
      int[] C = new int[k];
      // 计数
      for (int j = 0; j < A.Length; j++)
      {
        int a = A[j];
        C[a] += 1;
      }
      // 求计数和
      for (int i = 1; i < k; i++)
      {
        C[i] = C[i] + C[i - 1];
      }
      // 整理
      for (int j = A.Length - 1; j >= 0; j--)
      {
        int a = A[j];
        B[C[a] - 1] = a;
        C[a] -= 1;
      }
    }

    public static int[] countSort(int[] a)
    {
      int[] b = new int[a.Length];
      int max = a[0], min = a[0];
      foreach (int i in a)
      {
        if (i > max)
        {
          max = i;
        }
        if (i < min)
        {
          min = i;
        }
      }
      //这里k的大小是要排序的数组中，元素大小的极值差+1
      int k = max - min + 1;
      int[] c = new int[k];
      for (int i = 0; i < a.Length; ++i)
      {
        c[a[i] - min] += 1;//优化过的地方，减小了数组c的大小
      }
      for (int i = 1; i < c.Length; ++i)
      {
        c[i] = c[i] + c[i - 1];
      }
      for (int i = a.Length - 1; i >= 0; --i)
      {
        b[--c[a[i] - min]] = a[i];//按存取的方式取出c的元素
      }
      return b;
    }

    public int[] Sort(int[] array)
    {
      var max = array[0];
      var min = array[0];
      for (var i = 1; i < array.Length; i++)
      {
        max = System.Math.Max(max, array[i]);
        min = System.Math.Min(min, array[i]);
      }

      var countArray = new int[max - min + 1];
      for (var i = 0; i < array.Length; i++)
      {
        countArray[array[i] - min]++;
      }

      for (var i = 1; i < countArray.Length; i++)
      {
        countArray[i] = countArray[i] + countArray[i - 1];
      }

      var b = new int[array.Length];
      for (var i = array.Length - 1; i >= 0; i--)
      {
        countArray[array[i] - min]--;
        b[countArray[array[i] - min]] = array[i];
      }

      return b;
    }

    //this is my sort
    public int[] Sort1(int[] array)
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
