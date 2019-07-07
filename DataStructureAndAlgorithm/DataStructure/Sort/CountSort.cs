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

    //无内存优化并且限定输入数组的大小
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
        //用掉了一个，下次还有这个数就往前移动一位
        C[a] -= 1;
      }
    }
// 0,1,2,3,4,5,6
// 1,0,2,0,1,1,1
// 1,1,3,3,4,5,6
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
      //求最大最小值
      var max = array[0];
      var min = array[0];
      for (var i = 1; i < array.Length; i++)
      {
        max = System.Math.Max(max, array[i]);
        min = System.Math.Min(min, array[i]);
      }

      //计数，这里优化了内存
      var countArray = new int[max - min + 1];
      for (var i = 0; i < array.Length; i++)
      {
        countArray[array[i] - min]++;
      }

      //二次计数，用来求算数值在新数组中的index
      for (var i = 1; i < countArray.Length; i++)
      {
        countArray[i] = countArray[i] + countArray[i - 1];
      }

      //倒出数据
      var b = new int[array.Length];
      for (var i = array.Length - 1; i >= 0; i--)
      {
        //index = 数量-1 - min
        countArray[array[i] - min]--;
        b[countArray[array[i] - min]] = array[i];
      }

      return b;
    }
    
  }
}
