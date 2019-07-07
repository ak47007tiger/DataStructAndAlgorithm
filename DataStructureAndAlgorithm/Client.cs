using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Toolkit;
using LeetCode.Hard;
using LeetCode;
using LeetCode.Medium;
using NiuKeWang;

namespace DataStructure
{
  public class Client : BaseSolution
  {


    public static void Work(string[] args)
    {
      var array = new int[] { 3, 1, 9, 66, 23, 9, 15, 8, 6, 70 };
      // printArray(new QuickSort().Sort(array, 0, array.Length - 1));
      // printArray(new MergeSort().Sort(array, 0, array.Length - 1));
      // printArray(new QuickSort().Sort(array));
      // println();
      // printArray(new CountSort().Sort(array));
      // println();
      // printArray(CountSort.countingSort(array));
      // printArray(CountSort.countSort(array));
      // printArray(new RadixSort().Sort(array));
      // printArray(new BucketSort().UniverseSort(array));
      //   LowestCommonAncesterOfBST.Test();
      // UniqueBinarSearchTrees.Test();
      // println(63234f / 3600f);
      // println(57600f / 3600f);
      // Queens8.TestQueens8();
      // printArray(new BubbleSort().Sort(array));
      printArray(new QuickSort().Sort(array));
      // printArray(new BubbleSort().Sort2(array));
      println();
      Console.ReadKey();
    }

    public static bool IsChinese(char c){
      return 0x4e00 <= c && c <= 0x9fbb;
    }

  }
}