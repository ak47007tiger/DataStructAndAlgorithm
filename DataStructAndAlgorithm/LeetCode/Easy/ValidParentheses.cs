using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.

Example 1:

Input: "()"
Output: true
Example 2:

Input: "()[]{}"
Output: true
Example 3:

Input: "(]"
Output: false
Example 4:

Input: "([)]"
Output: false
Example 5:

Input: "{[]}"
Output: true
 */
/*
solution 1 stack
1 i from 1 to n
2 if c is open stack push(c)
  if c is close of stack top stack pop
3 return stack.count == 0
 */
namespace LeetCode.Easy {
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