public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;

        int n = nums.Length;
        int[] memo = new int[n];
        for (int i = 0; i < n; i++)
        {
            memo[i] = -1; // Initialize memoization array with -1
        }

        int maxLIS = 1;
        for (int i = 0; i < n; i++)
        {
            maxLIS = Math.Max(maxLIS, LIS_memo(nums, i, memo));
        }

        return maxLIS;
    }

    public static int LIS_memo(int[] nums, int currentIdx, int[] memo)
    {
        if (memo[currentIdx] != -1)
        {
            return memo[currentIdx];
        }

        int maxLIS = 1;
        for (int i = 0; i < currentIdx; i++)
        {
            if (nums[currentIdx] > nums[i])
            {
                maxLIS = Math.Max(maxLIS, 1 + LIS_memo(nums, i, memo));
            }
        }

        memo[currentIdx] = maxLIS;
        return maxLIS;
    }
}

// 2 -> 2 -> 1
//1 4 2 3 -> 1 2 3 -> 3