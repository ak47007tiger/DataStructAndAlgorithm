using System;
using System.Text;
using System.Collections.Generic;
namespace LeetCode.Main {
  using Toolkit;
  
  public class LeetCodeSolution {
    static Random random = new Random((int)(System.DateTime.Now.Ticks >> 5));
    public static int[] RandomData(int count){
      var data = new int[count];
      for(var i = 0; i < count; i++){
        data[i] = random.Next(count);
      }
      return data;
    }
    public static void print<T>(T t) {
      Printer.print(t);
    }

    public static void printArray<T>(params T[] array) {
      Printer.printArray(array);
    }

    public static void printIEnumerable<T>(IEnumerable<T> enumerable){
      Printer.printEnumerable(enumerable);
    }

    public static void printFormat(string format, params object[] objs){
      Printer.printFromat(format, objs);
    }

    public static void print(params object[] objs){
      var sbd = new StringBuilder();
      for(var i = 0; i < objs.Length - 1; i++){
        sbd.Append(objs[i].ToString()).Append(',');
      }
      sbd.Append(objs[objs.Length - 1]);
      print(sbd.ToString());
    }

  }
}