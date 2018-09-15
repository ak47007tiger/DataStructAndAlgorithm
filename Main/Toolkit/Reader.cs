using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LeetCode.Main.Toolkit {
  public class Reader {
    public static int[] Read2(string path) {
      List<int> numbers = new List<int>();
      var sr = File.OpenText(path);
      List<char> numberChars = new List<char>();
      var buf = new char[1024 * 1024];
      int count = sr.Read(buf, 0, buf.Length);
      char c;
      for (int i = 0; i < count; i++) {
        c = buf[i];
        if (c != ',') {
          numberChars.Add(c);
        } else {
          numbers.Add(int.Parse(new string(numberChars.ToArray())));
          numberChars.Clear();
        }
      }
      sr.Close();
      sr.Dispose();
      return numbers.ToArray();
    }

    public static int[] Read(string path) {
      List<int> numbers = new List<int>();
      var sr = File.OpenText(path);
      List<char> numberChars = new List<char>();
      char c = (char) sr.Read();
      while (c > -1) {
        if (c != ',') {
          numberChars.Add(c);
        } else {
          numbers.Add(int.Parse(new string(numberChars.ToArray())));
          numberChars.Clear();
        }
        c = (char) sr.Read();
      }
      sr.Close();
      sr.Dispose();
      return numbers.ToArray();
    }
  }
}