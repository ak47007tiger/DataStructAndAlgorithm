using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class ValidParentheses {
    public bool IsValid(string s) {
      if (string.IsNullOrEmpty(s))
        return false;
      if (s.Length % 2 == 1)
        return false;
      Dictionary<char, char> dic = new Dictionary<char, char>();
      dic.Add('(', ')');
      dic.Add('[', ']');
      dic.Add('{', '}');
      Stack<char> stack = new Stack<char>();
      for (int i = 0; i < s.Length; i++) {
        var c = s[i];
        if (dic.ContainsKey(c)) {
          stack.Push(s[i]);
          continue;
        }
        if (dic.ContainsValue(c)) {
          if (stack.Count == 0)
            return false;
          var top = stack.Pop();
          if (!dic.ContainsKey(top))
            return false;
          if (dic[top] != c)
            return false;
          continue;
        }
      }
      return stack.Count == 0;
    }
  }
}