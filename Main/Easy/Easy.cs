using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Main.Easy {
  public class Implement_strStr {
    public int StrStr(string haystack, string needle) {
      if (haystack == null || needle == null)
        return -1;
      if (needle == haystack)
        return 0;
      int j;
      for (int i = 0; i < haystack.Length - needle.Length + 1; i++) {
        for (j = 0; j < needle.Length; j++)
          if (haystack[i + j] != needle[j])break;
        if (j == needle.Length)return i;
      }
      return -1;
    }
  }

  public class PalindromeNumber {
    public bool IsPalindrome(int x) {
      var array = x.ToString().ToArray();
      int low = 0;
      int high = array.Length - 1;
      while (low < high) {
        if (array[low] != array[high])
          return false;
        low++;
        high--;
      }
      return true;
    }
  }

}