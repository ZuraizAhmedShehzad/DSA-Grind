public class Solution {
    public int LengthOfLIS(int[] nums) {
        // if(nums.Length == 0)
        //     return 0;
        
         List<int> seq = new List<int>();
         seq.Add(nums[0]);

        for(int i=0;i<nums.Length;i++){
            int lastElement = seq[seq.Count-1];
            if(lastElement >= nums[i]){
                int v = BS(seq,nums[i]);
                Console.WriteLine(v);
                seq[v] = nums[i];
            }
            else{
                seq.Add(nums[i]);
            }
        }

        return seq.Count;
    }

    public int BS(List<int> Seq, int Value){
        int r = Seq.Count - 1;
        int l = 0;

        while(r > l){
            int mid = l + (r - l)/2;
            if(Seq[mid] < Value){
                l = mid + 1;
            }
            else{
                r = mid;
            }
        }

        return l;
    }
}

//0
//0 1
//0 1
//0 1 3
//0 1 2
//0 1 2 3