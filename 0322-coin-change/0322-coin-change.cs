public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];

        // Initialize all values in dp to a large number (representing infinity).
        for (int i = 1; i <= amount; i++)
        {
            dp[i] = int.MaxValue;
        }

        // Base case: 0 coins needed to make amount 0.
        dp[0] = 0;

        // Iterate through each coin denomination.
        foreach (int coin in coins)
        {
            // Update dp for each amount from coin to the target amount.
            for (int i = coin; i <= amount; i++)
            {
                // Calculate the minimum number of coins needed.
                if (dp[i - coin] != int.MaxValue)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        // Check if it's possible to make the target amount.
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}

// [1,2,10,5] -> 17

// dp[0] = 0

// 1
// dp[1] = d[0]+1 = 1
// dp[2] = d[1]+1 = 2
// dp[3] = d[2]+1 = 3
// dp[3] = d[2]+1 = 3
// dp[3] = d[2]+1 = 3
// dp[3] = d[2]+1 = 3

// 2
// dp[2] = d[0] + 1 = 1
// dp[3] = d[1] + 1 = 2

// 5
