using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LeetCode.Main.Toolkit {
  public class TimeRecord {
    DateTime start;
    public void Start() {
      start = DateTime.Now;
    }
    public void End() {
      Printer.print(DateTime.Now - start);
    }
    public void Invoke(Action action) {
      Start();
      action.Invoke();
      End();
    }
  }
  
  public class Printer {
    public static void print<T>(T t) {
      Console.WriteLine(t);
    }

    public static void printFromat(string format, params object[] objs){
      Console.WriteLine(string.Format(format, objs));
    }

    public static void printArray<T>(T[] array) {
      for (int i = 0; i < array.Length - 1; i++) {
        Console.Write("{0},", array[i]);

      }
      print(array[array.Length - 1]);
    }
  }

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
      char c = (char)sr.Read();
      while (c > -1) {
        if (c != ',') {
          numberChars.Add(c);
        } else {
          numbers.Add(int.Parse(new string(numberChars.ToArray())));
          numberChars.Clear();
        }
        c = (char)sr.Read();
      }
      sr.Close();
      sr.Dispose();
      return numbers.ToArray();
    }
  }
}