public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] dp = new bool[s.Length+1];
        dp[s.Length] = true;

        for(int i=s.Length-1; i >= 0 ; i--){
            foreach(string word in wordDict){
                if((s.Length - i >= word.Length) && s.Substring(i,word.Length) == word){
                    dp[i] = dp[i + word.Length];
                }
                if(dp[i]){
                    break;
                }
            }
        }
        return dp[0];
    }
}