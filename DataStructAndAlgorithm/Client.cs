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
      var solution = new SelectCell();
      for(var i = 0; i < 10; i++){
        print(solution.SelectCount(i));
        print(',');
      }
      
      println(solution.SelectCount(4));
      Console.ReadKey();
    }
  }
}