using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class AddBinaryClass {
    public string AddBinary(string a, string b) {
      //carray
      //result value length bigger than max
      var index = 0;
      var c = new int[Math.Max(a.Length, b.Length)];
      while (index < Math.Min(a.Length, b.Length)) {
        var ca = a[a.Length - 1 - index];
        var cb = b[b.Length - 1 - index];
        var ba = ca == '0' ? 0 : 1;
        var bb = cb == '0' ? 0 : 1;
        c[c.Length - 1 - index] = ba + bb;
        index++;
      }
      //now index = min(a.length, b.length)
      for (var i = 0; i <= a.Length - 1 - index; i++) {
        c[i] = int.Parse(a[i].ToString());
      }
      for (var i = 0; i <= b.Length - 1 - index; i++) {
        c[i] = int.Parse(b[i].ToString());
      }
      for (var i = c.Length - 1; i > 0; i--) {
        var carray = c[i] > 1 ? 1 : 0;
        c[i - 1] += carray;
        c[i] = c[i] % 2;
      }
      var carray0 = c[0] > 1 ? 1 : 0;
      var sbd = new StringBuilder();
      if (carray0 == 1) {
        sbd.Append(1);
      }
      c[0] = c[0] % 2;
      foreach (var i in c) {
        sbd.Append(i);
      }
      return sbd.ToString();
    }

    string ArrayToStr(int[] array) {
      var sbd = new StringBuilder();
      foreach (var item in array) {
        sbd.Append(item);
      }
      return sbd.ToString();
    }
  }
}