public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        Array.Sort(nums);
        int j = 1; //working count
        int k = 0; //highest count

        for(int i = 0; i<nums.Length - 1;i++){
            if(nums[i] == nums[i+1]){
                continue;
            }
            if(nums[i] == (nums[i+1] - 1)){
                j++;
            }
            else{
                if(j > k){
                    k = j;
                    j = 1;
                }
                else{
                    j = 1;
                }
            }
        }
        if(j > k) return j;
        return k;
    }
}

