public class Solution {
    public int Fib(int n) {
        int[] dp = new int[3];
        dp[0] = 0;
        
        if(n>0)
         dp[1] = 1; 

        for(int i=2;i<=n;i++){
            dp[2] = dp[1]+dp[0];
            dp[0] = dp[1];
            dp[1] = dp[2];
        }

        return dp[1];
    }
}