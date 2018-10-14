using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace LeetCode.Easy {
  public class LengthOfLasstWord {
    public int LengthOfLastWord(string s) {
      if (string.IsNullOrEmpty(s))return 0;

      if (!s.Contains(' '))return s.Length;

      if (s.LastIndexOf(' ') == s.Length - 1)
        return LengthOfLastWord(s.Substring(0, s.Length - 1));

      return s.Length - s.LastIndexOf(' ') - 1;
    }
  }
}