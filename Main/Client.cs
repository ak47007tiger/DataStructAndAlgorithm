using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.Main.Easy;
using LeetCode.Main.Toolkit;

namespace LeetCode.Main {
  public class Client : LeetCodeSolution {
    public static void Work(string[] args) {
      var array = new int[]{
        1,2,3,1
      };
      var sl = new HouseRobber();
      array = new int[]{
        2,1,1,2
      };
      print(sl.Rob(null));
      print(sl.Rob(new int[]{1}));
      print(sl.Rob(new int[]{1,2}));
      print(sl.Rob(new int[]{2,1,2}));
      Console.ReadKey();
    }
  }
}