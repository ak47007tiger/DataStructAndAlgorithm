using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Toolkit;
using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using NiuKeWang;

namespace DataStructure {
  public class Client : BaseSolution {
    public static void Work(string[] args) {
      var solution = new DivideTwoIntegers();
      // println(solution.Divide(-2147483648, -1));
      // println(solution.Divide(10, 3));
      // println(solution.Divide(int.MaxValue, 2));
      println(solution.Mul(3,3));
      println(solution.Mul(3,2));
      Console.ReadKey();
    }
  }
}