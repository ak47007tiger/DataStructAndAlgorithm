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
Equations are given in the format A / B = k, where A and B are variables represented as strings, and k is a real number (floating point number). Given some queries, return the answers. If the answer does not exist, return -1.0.

Example:
Given a / b = 2.0, b / c = 3.0.
queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ? .
return [6.0, 0.5, -1.0, 1.0, -1.0 ].

The input is: vector<pair<string, string>> equations, vector<double>& values, vector<pair<string, string>> queries , where equations.size() == values.size(), and the values are positive. This represents the equations. Return vector<double>.

According to the example above:

equations = [ ["a", "b"], ["b", "c"] ],
values = [2.0, 3.0],
queries = [ ["a", "c"], ["b", "a"], ["a", "e"], ["a", "a"], ["x", "x"] ]. 
   */

/*
构造一个图，a/b 就是存在一个a->b的路径
只要能在图中找到a->b的路径就可以求出值
求 a/e, 找 a - b - c - d - e 这个路径
用hash table store 每个路径上的值 a-b = a / b, b-c = b / c
找到路径上的值乘起来就得到了结果
 */

  public class EvaluateDivision : BaseSolution
  {

    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
      //todo d.c implement
      //构造图
      //构造表达式映射
      //搜索路径
      //求路径值并相乘
      return null;
    }

  }

}
