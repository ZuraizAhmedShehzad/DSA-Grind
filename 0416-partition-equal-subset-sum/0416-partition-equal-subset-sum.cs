public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
    
        foreach (int num in nums)
        {
            sum += num;
        }
    
        if (sum % 2 != 0)
        {
            return false;
        }
        
        int targetSum = sum / 2;
        int n = nums.Length;

        bool[,] dp = new bool[n+1,targetSum+1];

        for (int i = 0; i <= n; i++)
        {
            dp[i, 0] = true;
        }

        for(int i=1;i<=n;i++){
            for(int j=1;j<=targetSum;j++){
                if(nums[i-1] > j){
                    dp[i,j] = dp[i-1,j];
                }
                else{
                    dp[i,j] = dp[i-1,j] || dp[i-1,j - nums[i-1]];
                }
            }
        }

        return dp[n,targetSum];
    }
}