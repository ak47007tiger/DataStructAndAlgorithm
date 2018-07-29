using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class PlausOne {
    public int[] PlusOne(int[] digits) {
      var carry = 1;
      var lastCarrayIndex = digits.Length;
      var index = digits.Length - 1;
      while (index >= 0 && carry == 1) {
        if (digits[index] + 1 > 9) {
          carry = 1;
          lastCarrayIndex = index;
          index--;
        } else {
          carry = 0;
        }
      }
      if (lastCarrayIndex != digits.Length) {
        if (lastCarrayIndex == 0) {
          var newDigits = new int[digits.Length + 1];
          newDigits[0] = 1;
          return newDigits;
        } else {
          digits[lastCarrayIndex - 1]++;
          for (var i = lastCarrayIndex; i < digits.Length; i++) {
            digits[i] = 0;
          }
          return digits;
        }
      } else {
        digits[digits.Length - 1]++;
        return digits;
      }
    }

    public int[] PlusOneNormal(int[] digits) {
      var sbd = new StringBuilder();
      foreach (var item in digits) {
        sbd.Append(item);
      }
      var plus = int.Parse(sbd.ToString()) + 1;
      var plusStr = plus.ToString();
      var result = new int[plusStr.Length];
      for (var i = 0; i < plusStr.Length; i++) {
        result[i] = int.Parse(plusStr.Substring(i, 1));
      }
      return result;
    }
  }
}