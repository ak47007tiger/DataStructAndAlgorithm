using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.Main.Easy;
using LeetCode.Main.Toolkit;

namespace LeetCode.Main {
  public class Client : LeetCodeSolution {
    public static void Work(string[] args) {

      var exc = new ExcelSheetColumnTitle();
      print(exc.ConvertToTitle(1));
      print(exc.ConvertToTitle(26));
      print(exc.ConvertToTitle(27));
      print(exc.ConvertToTitle(28));
      print(exc.ConvertToTitle(29));
      print(exc.ConvertToTitle(701));

      Console.ReadKey();
    }
  }
}