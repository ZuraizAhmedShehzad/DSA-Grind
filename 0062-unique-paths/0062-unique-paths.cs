public class Solution {
    Dictionary<(int,int),int> dp = new Dictionary<(int,int),int>();
    public int UniquePaths(int m, int n) {
        return Dp(m, n, 0, 0);
    }

    public int Dp(int m, int n, int currm, int currn){
        if(currm >= m || currn >= n){
            return 0;
        }
        if(currm == m-1 && currn == n-1){
            return 1;
        }

        if(!dp.ContainsKey((currm,currn))){
            dp[(currm,currn)] = Dp(m,n,currm+1,currn) + Dp(m,n,currm,currn+1);
        }
        
        return dp[(currm,currn)];
    }
}