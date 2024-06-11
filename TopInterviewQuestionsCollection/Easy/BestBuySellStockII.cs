using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Easy
{
    //You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
    //On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time.
    //However, you can buy it then immediately sell it on the same day.
    //Find and return the maximum profit you can achieve.
    public static class BestBuySellStockII
    {
        public static int MaxProfit(int[] prices)
        {
            int boughtIndex = 0;
            bool bought = false;
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {

                if (prices[i] <= prices[i + 1])
                {
                    if (!bought)
                    {
                        bought = true;
                        boughtIndex = i;
                    }

                }
                else
                {
                    if (bought)
                    {
                        bought = false;
                        profit += prices[i] - prices[boughtIndex];
                    }
                }
            }
            if(bought)
            {
                profit += prices[prices.Length - 1] - prices[boughtIndex];
            }
            return profit;
        }
    }
}
