using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

Note: For the purpose of this problem, we define empty string as valid palindrome.

Example 1:

Input: "A man, a plan, a canal: Panama"
Output: true
Example 2:

Input: "race a car"
Output: false
 */

/*
思路
从前往后和从后往前只数字母得到的字母是一样的
 */
namespace LeetCode.Main.Easy {

  public class ValidPalindrome {

    public bool IsPalindrome(string s) {
      if(string.IsNullOrEmpty(s)){
        return true;
      }
      var sbd = new StringBuilder();
      var d = 'A' - 'a';
      for(var i = 0; i < s.Length; i++){
        var c = s[i];
        if('A' <= s[i] && s[i] <= 'Z'){
          c = (char)(c - d);
        }
        if(('a' <= c && c <= 'z') || '0' <= c && c <= '9'){
          sbd.Append(c);
        }
      }
      for(var i = 0; i < sbd.Length / 2; i++){
        var to = sbd.Length - 1 - i;
        if(sbd[i] != sbd[to]) return false;
      }
      return true;
    }

  }

}