using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
/*
Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).

Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).

Example 1:

Input: [7,1,5,3,6,4]
Output: 7
Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
             Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
Example 2:

Input: [1,2,3,4,5]
Output: 4
Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
             Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are
             engaging multiple transactions at the same time. You must sell before buying again.
Example 3:

Input: [7,6,4,3,1]
Output: 0
Explanation: In this case, no transaction is done, i.e. max profit = 0.
 */
/*
建模
求2数差的和最大
约束，下一次求差的index>上一次求差数的index
是不是可以用递归或者动态规划
不可以用递归，没有相同结构的子问题
动态规划的使用条件，能够找到递推公式

看了答案之后的思考
暴力解法里用了递归
因为要求出所有的可能恰好出现了：输入范围不同但是解法相同的问题

最优解1
分析数据直接的关系，发现最大差和是所有相邻的谷底和谷峰的差和
1 找下一个谷底galley，找下一个谷峰peak，加入sum
2 重复1，直到找不到下一个谷底或者谷峰


 */
  public class BestTimeToBuyAndSellStock2 {
    public int MaxProfit(int[] prices) {
      var profit = 0;
      return profit;
    }
    
  }
}