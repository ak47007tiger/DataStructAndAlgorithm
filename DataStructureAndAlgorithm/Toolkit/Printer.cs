using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DataStructure.Toolkit
{
    public class Printer
    {
        public static void print<T>(T t)
        {
            Console.Write(t);
        }

        public static void println<T>(T t)
        {
            Console.WriteLine(t);
        }

        public static void printFromat(string format, params object[] objs)
        {
            Console.Write(string.Format(format, objs));
        }

        public static void printArray<T>(params T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("{0},", array[i]);
            }
            print(array[array.Length - 1]);
        }

        public static void printEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.Write("{0},", item);
            }
        }

        public static void LogDuration(Action action)
        {
            println("----------------------- time tick start -----------------------");
            var before = DateTime.Now.Ticks;
            action();
            var after = DateTime.Now.Ticks;
            printFromat("{0} = {1} - {2}", after - before, after, before);
            println("----------------------- time tick end -----------------------");
        }
    }
}