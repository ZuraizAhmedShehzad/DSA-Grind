public class Solution {
    //Tabulation
    // public int Fib(int n) {
    //     int[] dp = new int[3];
    //     dp[0] = 0;
        
    //     if(n>0)
    //      dp[1] = 1; 

    //     for(int i=2;i<=n;i++){
    //         dp[2] = dp[1]+dp[0];
    //         dp[0] = dp[1];
    //         dp[1] = dp[2];
    //     }

    //     return dp[1];
    // }
    
    //Memoization
    Dictionary<int,int> dp = new Dictionary<int,int>();
    public int Fib(int n) {
        return Dp(n,dp);
    }
    public int Dp(int n, Dictionary<int,int> dp){
        if(n == 0)
            return 0;
        if(n == 1)
            return 1;
        
        if(dp.ContainsKey(n))
            return dp[n];
        
        dp[n] = Dp(n-1,dp)+Dp(n-2,dp);
        return dp[n];
    }
}