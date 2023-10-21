public class Solution {
    public int UniquePaths(int m, int n)
    {
        // Create a memoization table to store computed results
        int[,] memo = new int[m, n];
        
        // Helper function for recursive memoization
        int Helper(int row, int col)
        {
            // Base case: if we reach the bottom-right corner, there's only one path
            if (row == m - 1 && col == n - 1)
                return 1;
            
            // If we've already computed the result, return it from the memo table
            if (memo[row, col] != 0)
                return memo[row, col];
            
            // Calculate the number of unique paths by moving right and down
            int right = 0;
            int down = 0;
            
            if (col < n - 1)
                right = Helper(row, col + 1);
            
            if (row < m - 1)
                down = Helper(row + 1, col);
            
            // Store the result in the memo table and return it
            memo[row, col] = right + down;
            return memo[row, col];
        }
        
        // Start the recursion from the top-left corner
        return Helper(0, 0);
    }
}