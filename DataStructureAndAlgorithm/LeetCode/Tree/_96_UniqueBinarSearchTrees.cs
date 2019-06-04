using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;
using DataStructure.Toolkit;

namespace LeetCode
{
  /*
  Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?

  Example:

  Input: 3
  Output: 5
  Explanation:
  Given n = 3, there are a total of 5 unique BST's:

     1         3     3      2      1
      \       /     /      / \      \
       3     2     1      1   3      2
      /     /       \                 \
     2     1         2                 3
   */

  /*
  以任意一个数作为根节点用剩下的数可以构造多少子树

  n
  n - 1
  n - 2

  0 1
  1 1
  2 2
  3 5
  4 14

  c0 = 1
  c(n+1) = sum(ci-c(n-i)) , n>=0
  c(n) = sum(c(i-1)-c(n-i-1)) , n>=0
  */
  public class UniqueBinarSearchTrees : BaseSolution
  {

    public int NumTrees(int n)
    {
      var count = new int[n + 1];
      count[0] = 1;
      count[1] = 1;
      for (var k = 2; k <= n; k++)
      {
        var val = 0;
        for (var i = 0; i < k; i++)
        {
          val += (count[i] * count[k - 1 - i]);
        }
        count[k] = val;
      }
      return count[n];
    }

    public static void Test(){
      print(new UniqueBinarSearchTrees().NumTrees(4));
    }
  }

}
