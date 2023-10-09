public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> remainder = new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++){
            int answer = target - nums[i];

            if(remainder.ContainsKey(answer)){
                return new int[] {remainder[answer],i};    
            }
            else{
                if(!remainder.ContainsKey(nums[i])){
                    remainder.Add(nums[i], i);
                }
            }
        }

        return new int[] {};
    }
}