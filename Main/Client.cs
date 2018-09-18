using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.Main.Easy;
using LeetCode.Main.Toolkit;

namespace LeetCode.Main {
  public class Client : LeetCodeSolution{
    public static void Work(string[] args) {
      print(new BestTimeToBuyAndSellStock().MaxProfit(
        new int[]{7,1,5,3,6,4}
      ));
      print(new BestTimeToBuyAndSellStock().MaxProfit(
        new int[]{7,6,4,3,1}
      ));
      Console.ReadKey();
    }
  }
}