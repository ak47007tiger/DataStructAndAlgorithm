using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Toolkit;
using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using NiuKeWang;

namespace DataStructure
{
    public class Client : BaseSolution
    {
        public static void TestArrayMaxHeap()
        {
            var array = new int[] { 2, 4, 6, 7, 8, 3, 2, 5 };
            var solution = new ArrayMaxHeap();
            solution.Build(array.Length);
            foreach (var num in array)
            {
                solution.Insert(num);
                print(solution.GetTop());
                print(',');
            }
            println();
            while (solution.GetSize() > 0)
            {
                print(solution.RemoveTop());
                print(',');
            }
        }

        public static void Work(string[] args)
        {
            var array = new int[]{3,1,9,66,23,9,15,8,6,70};
            // printArray(new QuickSort().Sort(array, 0, array.Length - 1));
            // printArray(new MergeSort().Sort(array, 0, array.Length - 1));
            printArray(new QuickSort().Sort(array));
            println();
            printArray(new CountSort().Sort(array));
            println();
            // printArray(CountSort.countingSort(array));
            printArray(CountSort.countSort(array));
            Console.ReadKey();
        }
    }
}