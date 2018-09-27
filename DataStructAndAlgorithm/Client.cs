using System;
using System.Collections;
using System.Collections.Generic;
using DataStruct.Toolkit;
using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using NiuKeWang;

namespace DataStruct {
  public class Client : BaseSolution {
    public static void Work(string[] args) {
      var solution = new FirstBadVersionCls();
      

      print(solution.FirstBadVersion(3));
      Console.ReadKey();
    }
  }
}