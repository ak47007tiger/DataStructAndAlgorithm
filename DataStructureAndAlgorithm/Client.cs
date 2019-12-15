using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Toolkit;
using LeetCode.Hard;
using LeetCode;
using LeetCode.Medium;
using NiuKeWang;
using DataStructure.Test;
using System.Text.RegularExpressions;
using Test;

namespace DataStructure
{
    public class Client : BaseSolution
    {
        /// <summary>
        /// fwqef
        /// </summary>
        /// <param name="args"></param>
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
            // new CircularLinkedListTest().SimpleTest();
            // new ArrayBinaryTreeTest().SimpleTest();
            // new LinkedUndigraphTest().Test();
            // new TestClassDefault().Test();
            // new TestCloneEntity().Clone();
            // new TestTwoStringCompare().Compare();
            // new TestDelegate().Test();
            // new TestMessageSystem().Test();
            // new TestDictionary().Test();
            // new TestHttp().Test();
            new ArrayQueueTest().Test();
            Console.ReadKey();
        }

        public static void TestRegMatch()
        {
            // var regStr = "G\\.R\\(\\\"([^\\\"]+)";
            var target = @"";
            var regStr = "\"\"";
            Regex m_codeRegex = new Regex(regStr);
            println(regStr);
            // println(m_codeRegex.Match(target));
            var collection = m_codeRegex.Matches(target);
            foreach (var item in collection)
            {
                println(item);
            }
        }

    }
}