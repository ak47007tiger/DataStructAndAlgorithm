using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode {
  public class PalindromeNumber {
    public bool IsPalindrome(int x) {
      var array = x.ToString().ToArray();
      int low = 0;
      int high = array.Length - 1;
      while (low < high) {
        if (array[low] != array[high]) {
          return false;
        }
        low++;
        high--;
      }
      return true;
    }
  }
}