public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
        int target = 0;

        foreach(var num in nums){
            sum+= num;
        }
        if(sum%2 != 0){
            return false;
        }

        target = sum/2;

        Dictionary<(int,int),bool> memo = new Dictionary<(int,int),bool>();
        return Solve(nums,target,0,memo);
    }

    public bool Solve(int[] nums,int target, int i,Dictionary<(int,int),bool> memo){
        if(i >= nums.Length){
            return false;
        }
        if(target < 0){
            return false;
        }
        if(target == 0){
            return true;
        }

        if(memo.ContainsKey((i,target))){
            return memo[(i,target)];
        }

        memo[(i,target)] = Solve(nums,target-nums[i],i+1,memo) || Solve(nums,target,i+1,memo);

        return memo[(i,target)];
    }
}