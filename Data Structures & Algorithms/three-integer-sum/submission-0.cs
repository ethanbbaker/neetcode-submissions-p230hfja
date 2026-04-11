public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        HashSet<(int, int, int)> foundTriplets = new HashSet<(int, int, int)>();
        for(int i = 0; i<nums.Length - 2; i++){
           for(int j = i + 1; j<nums.Length; j++){
                for(int k = j + 1; k<nums.Length; k++){
                    if(nums[i] + nums[j] + nums[k] == 0){
                        int[] array = {nums[i], nums[j], nums[k]};
                        Array.Sort(array);
                        var x = (array[0], array[1], array[2]);
                        if(foundTriplets.Contains(x)){
                            continue;
                        }
                        else{
                            foundTriplets.Add(x);
                        }
                    }
                }
            } 
        }
        var res = new List<List<int>>();
        foreach(var triplet in foundTriplets){
            res.Add(new List<int>{triplet.Item1, triplet.Item2, triplet.Item3 });
        }
        return res;
    }
}
