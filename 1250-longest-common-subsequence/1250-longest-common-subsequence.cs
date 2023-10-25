public class Solution {
    static Dictionary<(int, int), int> memo;

    // static int LongestCommonSubsequence(string text1, string text2, int i, int j)
    // {
    //     if (i < 0 || j < 0)
    //     {
    //         return 0;
    //     }

    //     if (memo.ContainsKey((i, j)))
    //     {
    //         return memo[(i, j)];
    //     }

    //     if (text1[i] == text2[j])
    //     {
    //         memo[(i, j)] = 1 + LongestCommonSubsequence(text1, text2, i - 1, j - 1);
    //     }
    //     else
    //     {
    //         memo[(i, j)] = Math.Max(
    //             LongestCommonSubsequence(text1, text2, i - 1, j),
    //             LongestCommonSubsequence(text1, text2, i, j - 1)
    //         );
    //     }

    //     return memo[(i, j)];
    // }

    // public int LongestCommonSubsequence(string text1, string text2)
    // {
    //     memo = new Dictionary<(int, int), int>();
    //     return LongestCommonSubsequence(text1, text2, text1.Length - 1, text2.Length - 1);
    // }

    public int LongestCommonSubsequence(string text1, string text2)
    {
        int[,] dp = new int[text1.Length+1,text2.Length+1];
        
        for (int i = 0; i <= text1.Length; i++)
            for (int j = 0; j <= text2.Length; j++)
                dp[i, j] = 0;
    
        for(int i=1;i<=text1.Length;i++){
            for(int j=1;j<=text2.Length;j++){
                if(text1[i-1] == text2[j-1]){
                    dp[i,j] = dp[i-1,j-1] + 1;
                }
                else{
                    dp[i,j] = Math.Max(dp[i,j-1],dp[i-1,j]);
                }
            }
        }

        return dp[text1.Length,text2.Length];
    }
}


//AB