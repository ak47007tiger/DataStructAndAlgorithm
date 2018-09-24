using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy {
  public class ReverseInteger {
    public string reverse(string src) {
      var array = src.ToArray();
      int low = 0;
      int high = array.Length - 1;
      char temp = array[low];
      while (low < high) {
        temp = array[low];
        array[low] = array[high];
        array[high] = temp;
        low++;
        high--;
      }
      return new string(array);
    }
    public int Reverse(int x) {
      if (x == 0)
        return 0;
      if (x > 0) {
        var s = x.ToString();
        s = reverse(s);
        var r = long.Parse(s);
        if (r > int.MaxValue)
          return 0;
        else
          return (int)r;
      } else {
        var s = x.ToString();
        s = s.Substring(1, s.Length - 1);
        s = reverse(s);
        var r = -long.Parse(s);
        if (r < int.MinValue)
          return 0;
        else
          return (int)r;
      }
    }
  }
}