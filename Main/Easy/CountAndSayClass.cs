using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class CountAndSayClass {
    string[] define = { "", "1", "11", "21", "1211", "111221" };
    char[] defineNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public string CountAndSay(int n) {
      if (n <= 5)return define[n];
      string previous = CountAndSay(n - 1);
      StringBuilder sbd = new StringBuilder();
      Stack<char> stack = new Stack<char>();
      for (int i = 0; i < previous.Length; i++) {
        if (stack.Count == 0) {
          stack.Push(previous[i]);
          continue;
        }

        if (stack.Peek() == previous[i])
          stack.Push(previous[i]);
        else {
          sbd.Append(defineNumbers[stack.Count]);
          sbd.Append(stack.Peek());
          stack.Clear();
          stack.Push(previous[i]);
        }
      }
      sbd.Append(defineNumbers[stack.Count]);
      sbd.Append(stack.Peek());
      return sbd.ToString();
    }
  }
}