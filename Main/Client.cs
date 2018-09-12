using System;
using LeetCode.Main.Easy;
using LeetCode.Main.Toolkit;

namespace LeetCode.Main {
  public class Client : LeetCodeSolution{
    public static void Work(string[] args) {
      ClimbStairs climbStairs = new ClimbStairs();
      print(climbStairs.Solution1(5));
      print(climbStairs.Solution2(5));
      print(climbStairs.Solution2(4));
      print(climbStairs.Solution3(3));
      print(climbStairs.Solution3(4));
      print(climbStairs.Solution3(5));
      Console.ReadKey();
    }
  }
}