using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class Implement_strStr {
    public int StrStr(string haystack, string needle) {
      if (haystack == null || needle == null) {
        return -1;
      }
      if (needle == haystack) {
        return 0;
      }
      int j;
      for (int i = 0; i < haystack.Length - needle.Length + 1; i++) {
        for (j = 0; j < needle.Length; j++) {
          if (haystack[i + j] != needle[j]) {
            break;
          }
        }
        if (j == needle.Length) {
          return i;
        }
      }
      return -1;
    }
  }
}