using System.Text;
namespace LeetCode.Main {
  using Toolkit;
  
  public class LeetCodeSolution {
    public static void print<T>(T t) {
      Printer.print(t);
    }

    public static void printArray<T>(T[] array) {
      Printer.printArray(array);
    }

    public static void printFormat(string format, params object[] objs){
      Printer.printFromat(format, objs);
    }

    public static void print(params object[] objs){
      var sbd = new StringBuilder();
      for(var i = 0; i < objs.Length - 1; i++){
        sbd.Append(objs[i].ToString()).Append(',');
      }
      sbd.Append(objs[objs.Length - 1]);
      print(sbd.ToString());
    }

  }
}