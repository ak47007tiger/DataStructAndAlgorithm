using System;
using LeetCode.Main.Easy;

namespace LeetCode.Main {
  public class Client {
public static void print<T>(T t) {
      Print.print(t);
    }

    public static void printArray<T>(T[] array) {
      Print.printArray(array);
    }

    public static void Work(string[] args) {
      print(new Solutions_11_20().ClimbStairs(3));
      Console.ReadKey();
    }
  }
}