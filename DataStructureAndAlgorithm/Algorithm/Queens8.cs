using System;
namespace DataStructure
{
  /*
  计算8皇后问题有多少不同的解

  问题：
  如何能够在8×8的国际象棋棋盘上放置八个皇后，使得任何一个皇后都无法直接吃掉其他的皇后
  任两个皇后都不能处于同一条横行、纵行或斜线上
   */
  public class Queens8
  {
    /*
    用来放置皇后
    值j在数组中的位置i表明第i个皇后放在第j列上
     */
    int[] array = new int[9];
    public int[] sums = new int[9];

    /*
    判断当前摆法是否合理
    不在同一行：因为摆放的时候 array[index] = j 保证每个皇后都不在同一行
    不在同一列：array 中没有相同的值
    不在对角线：(r1,c1), (r2,c2) 一个位置(r,c)，当两个位置|r-r2| == |c-c2|的值相同则在对角线
     */
    public bool Pass(int n)
    {
      if (n == 1)
      {
        return true;
      }
      /*
      某一列和它后面所有的列比较
      某一个位置和它后面所有的位置比较
       */
      for (var r = 1; r <= n; r++)
      {
        for (var r2 = r + 1; r2 <= n; r2++)
        {
          //列相同
          if (array[r] == array[r2])
          {
            return false;
          }
          //任意2个位置对角线
          if (Math.Abs(r - r2) == Math.Abs(array[r] - array[r2]))
          {
            return false;
          }
        }
      }

      return true;
    }

    public int Calculate(int pos)
    {
      if (pos > 8)
      {
        return 1;
      }
      else
      {
        var sum = 0;
        for (var j = 1; j <= 8; j++)
        {
          array[pos] = j;
          if (Pass(pos))
          {
            sum += Calculate(pos + 1);
          }
        }
        sums[pos] = sum;
        return sum;
      }
    }

    public static void TestQueens8()
    {
      var q8 = new Queens8();
      var r = q8.Calculate(1);
      var sums = q8.sums;
      BaseSolution.println(r);
      BaseSolution.printArray(sums);
    }
  }

}