using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy {
/*
Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

Note that you cannot sell a stock before you buy one.

Example 1:

Input: [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
             Not 7-1 = 6, as selling price needs to be larger than buying price.
Example 2:

Input: [7,6,4,3,1]
Output: 0
Explanation: In this case, no transaction is done, i.e. max profit = 0.
 */
/*
解题
建模
求一个数组中一个数a它右边最大的那个数c，差值为d = c - a
求min(d)

先求ds = [所有右边的数-左边的数的差]
求ds里面最小的

我知道有一种剪枝方式可以减少对比和循环

如果一个数比前面的一个数大，那么它就不能入选
继续缩小范围，如果一个数比前面最小的那个数大，那么它就不能入选
如何在比较profit的同时维护一个已经筛选过的段的最小值？
维护一个profit，维护一个筛选过的段的最小值

 */
  public class BestTimeToBuyAndSellStock {
    public int MaxProfit(int[] prices) {
      var profit = 0;
      for(var i = 0; i < prices.Length; i++){
        var buy = prices[i];
        for(var j = i + 1; j < prices.Length; j++){
          var sell = prices[j];
          var d = sell - buy;
          profit = Math.Max(profit, d);
        }
      }
      return profit;
    }

    
  }
}