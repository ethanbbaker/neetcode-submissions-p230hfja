public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        for(int i =0 ;i < prices.Length; i++){
            for(int j =i + 1 ;j < prices.Length; j++){
                if(prices[i] >= prices[j]) continue;
                int diff = prices[j] - prices[i];
                if(diff > profit) profit = diff;
            }
        }
        return profit;
    }
}
