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
            printArray(new ShellSort().Sort(new int[]{3,1,66,23,9,15,8,6,70}));
            Console.ReadKey();
        }
    }
}