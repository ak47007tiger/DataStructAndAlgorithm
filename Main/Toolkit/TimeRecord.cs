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
}