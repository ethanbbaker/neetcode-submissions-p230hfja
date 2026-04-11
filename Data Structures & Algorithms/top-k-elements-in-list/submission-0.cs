public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++){
            int number = nums[i];
            if(!dict.TryGetValue(number, out var count)){
                dict.Add(number, 0);
            }
            dict[number] = count + 1;
        }
        return dict.OrderByDescending(x => x.Value).Take(k).Select(kvp => kvp.Key).ToArray();
    }
}
