using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode {
  public class RomanToInteger {
    public int RomanToInt(string s) {
      Dictionary<char, int> dir = new Dictionary<char, int>();
      dir.Add('I', 1);
      dir.Add('V', 5);
      dir.Add('X', 10);
      dir.Add('L', 50);
      dir.Add('C', 100);
      dir.Add('D', 500);
      dir.Add('M', 1000);

      if (s.Length == 0) {
        return 0;
      }

      int i = s.Length - 1;
      char previous = s[i];
      int sum = dir[previous];
      while (i > 0) {
        if (s[i] == s[i - 1]) {
          sum += dir[s[i - 1]];
        } else {
          if (dir[s[i]] < dir[s[i - 1]]) {
            sum += dir[s[i - 1]];
          } else {
            sum -= dir[s[i - 1]];
          }
        }
        i--;
      }
      return sum;
    }
  }
}