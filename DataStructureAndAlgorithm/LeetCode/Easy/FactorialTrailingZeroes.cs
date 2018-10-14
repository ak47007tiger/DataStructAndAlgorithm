using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

/*
Given an integer n, return the number of trailing zeroes in n!.

Example 1:

Input: 3
Output: 0
Explanation: 3! = 6, no trailing zero.
Example 2:

Input: 5
Output: 1
Explanation: 5! = 120, one trailing zero.
Note: Your solution should be in logarithmic time complexity.
 */

/*
我用了耿直的大数相乘算出阶乘，然后用字符串数0...
还做了一次优化，一直超时

看了答案是在找有多少个5
 */

namespace LeetCode.Easy {

  public class FactorialTrailingZeroes : BaseSolution {

    public int TrailingZeroes(int n) {
      var sum = 0;
      while(n > 0){
        sum += n / 5;
        n /= 5;
      }
      return sum;
    }

    public int TrailingZeroes4(int n) {
      var value = new char[] { '1' };
      for (var i = 2; i <= n; i++) {
        value = Mul(value, i.ToString().ToArray());
      }
      var sum = 0;
      for (var i = value.Length - 1; i >= 0; i--) {
        if (value[i] != '0') {
          return sum;
        }
        sum++;
      }
      return sum;
    }

    public char[] Mul(char[] a, char[] b) {
      //var dic = new Dictionary<int, int>();
      var dic = new int[a.Length + b.Length];
      for (var i = b.Length - 1; i >= 0; i--) {
        var ri = b.Length - 1 - i;
        for (var j = a.Length - 1; j >= 0; j--) {
          var rj = a.Length - 1 - j;
          var value = Mul(b[i], a[j]);
          var leftIndex = ri + rj;
          UpdateDic(dic, value, leftIndex);
        }
      }
      var start = 0;
      for (var i = dic.Length - 1; i >= 0; i--) {
        if (dic[i] > 0) {
          start = i;
          break;
        }
      }
      var list = new List<char>();
      for (var i = start; i >= 0; i--) {
        list.Add(ToC(dic[i]));
      }
      return list.ToArray();
    }

    void UpdateDic(int[] dic, int value, int index) {
      var old = dic[index];
      var newValue = old + value;
      var left = newValue % 10;
      dic[index] = left;
      var up = (newValue / 10);
      if (up > 0) {
        UpdateDic(dic, up, index + 1);
      }
    }

    int Mul(char a, char b) {
      return ToI(a) * ToI(b);
    }

    int ToI(char a) {
      switch (a) {
        case '1':
          return 1;
        case '2':
          return 2;
        case '3':
          return 3;
        case '4':
          return 4;
        case '5':
          return 5;
        case '6':
          return 6;
        case '7':
          return 7;
        case '8':
          return 8;
        case '9':
          return 9;
      }
      return 0;
    }

    char ToC(int i) {
      switch (i) {
        case 1:
          return '1';
        case 2:
          return '2';
        case 3:
          return '3';
        case 4:
          return '4';
        case 5:
          return '5';
        case 6:
          return '6';
        case 7:
          return '7';
        case 8:
          return '8';
        case 9:
          return '9';
      }
      return '0';
    }

    void UpdateDic(Dictionary<int, int> dic, int value, int index) {
      var old = dic.ContainsKey(index) ? dic[index] : 0;
      var newValue = old + value;
      var left = newValue % 10;
      dic[index] = left;
      var up = (newValue / 10);
      if (up > 0) {
        UpdateDic(dic, up, index + 1);
      }
    }

    public int TrailingZeroes3(int n) {
      string value = "1";
      for (var i = 2; i <= n; i++) {
        value = AMulB(value, i.ToString());
      }
      var sum = 0;
      for (var i = value.Length - 1; i >= 0; i--) {
        if (value[i] != '0') {
          return sum;
        }
        sum++;
      }
      return sum;
    }

    public int TrailingZeroes2(int n) {
      string value = "1";
      for (var i = 2; i <= n; i++) {
        value = AMulB(value, i.ToString());
      }
      var sum = 0;
      for (var i = value.Length - 1; i >= 0; i--) {
        if (value[i] != '0') {
          return sum;
        }
        sum++;
      }
      return sum;
    }

    public int TrailingZeroes1(int n) {
      long value = 1;
      for (var i = 2; i <= n; i++) {
        value *= i;
      }
      var str = value.ToString();

      var sum = 0;
      for (var i = str.Length - 1; i >= 0; i--) {
        if (str[i] != '0') {
          return sum;
        }
        sum++;
      }
      return sum;
    }

    public string AMulB(string a, string b) {
      var sum = "0";
      for (var i = 0; i < b.Length; i++) {
        var zeroCount = b.Length - 1 - i;
        sum = Add(sum, AMulB(a, b[i], zeroCount));
      }
      return sum;
    }

    public string AMulB(string a, char b, int zeroCount) {
      if (b == '0')return "0";
      if (a[0] == '0')return "0";

      var stackA = new Stack<char>(a);
      var listC = new List<char>();
      var listD = new List<char>();
      while (stackA.Count > 0) {
        var c = stackA.Pop();
        var result = Mul(c, b);
        listC.Add(ToC(result % 10));
        if (listD.Count < listC.Count) {
          listD.Add('0');
        }
        if (result > 9) {
          listD.Add(ToC(result / 10));
        }
      }
      while (stackA.Count > 0) {
        listC.Add(stackA.Pop());
      }
      listC.Reverse();
      RemoveZeroChar(listC);
      listD.Reverse();
      RemoveZeroChar(listD);
      return Add(new string(listC.ToArray()), new string(listD.ToArray())) + ZeroStr(zeroCount);
    }

    string ZeroStr(int count) {
      if (count == 0)return string.Empty;
      var buf = new char[count];
      System.Array.Fill(buf, '0');
      return new string(buf);
    }

    Stack<char> ToStack(string a) {
      var stack = new Stack<char>();
      for (var i = 0; i < a.Length; i++) {
        stack.Push(a[i]);
      }
      return stack;
    }

    public string Add(string a, string b) {
      var stackA = ToStack(a);
      var stackB = ToStack(b);
      var listC = new List<char>();
      var listD = new List<char>();

      var dIsNum = false;
      while (stackA.Count > 0 && stackB.Count > 0) {
        var ca = stackA.Pop();
        var cb = stackB.Pop();
        var result = Add(ca, cb);
        listC.Add(ToC(result % 10));
        if (listD.Count < listC.Count) {
          listD.Add('0');
        }
        if (result > 9) {
          listD.Add('1');
          dIsNum = true;
        }
      }

      while (stackA.Count > 0) {
        listC.Add(stackA.Pop());
      }
      while (stackB.Count > 0) {
        listC.Add(stackB.Pop());
      }

      listC.Reverse();
      RemoveZeroChar(listC);

      if (dIsNum) {
        listD.Reverse();
        RemoveZeroChar(listD);
        return Add(new string(listC.ToArray()), new string(listD.ToArray()));
      } else {
        return new string(listC.ToArray());
      }
    }

    void RemoveZeroChar(List<char> list) {
      while (list.Count > 1) {
        if ('0' == list[0]) {
          list.RemoveAt(0);
        } else {
          return;
        }
      }
    }

    int Add(char a, char b) {
      return ToI(a) + ToI(b);
    }

    bool More9(char a, char b) {
      return ToI(a) + ToI(b) > 9;
    }

    char Left(char a, char b) {
      return ToC(ToI(a) + ToI(b) - 10);
    }

  }

}