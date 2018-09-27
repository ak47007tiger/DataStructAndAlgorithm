using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStruct;
using DataStruct.Toolkit;

namespace LeetCode.Easy {
  /*
  You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

  Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

  You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

  Example:

  Given n = 5, and version = 4 is the first bad version.

  call isBadVersion(3) -> false
  call isBadVersion(5) -> true
  call isBadVersion(4) -> true

  Then 4 is the first bad version. 
   */

  /*
  寻找不是bad verion的最大的那个n
  怎么知道找到了最大的那个
  previous最新最大的bad version
  previous = n
  cur = n / 2，
  if cur bad
    previous = cur, cur

   */

  /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
  public class FirstBadVersionCls : BaseSolution {
    public int FirstBadVersion(int n) {
      var previous = n;
      var cur = n;
      while (true) {
        if (IsBadVersion(cur)) {
          if(!IsBadVersion(cur - 1)){
            return cur;
          }
          previous = cur;
          cur = cur / 2;
        } else {
          if (IsBadVersion(cur + 1)) {
            return cur + 1;
          }
          cur = cur / 2 + previous / 2;
        }
        print(cur);
        print(',');
      }
    }

    bool IsBadVersion(int version) {
      return version >= 3;
    }
  }
}