public class Solution {
    public int MaxArea(int[] heights) {
        int x = 0;
        for(int i = 0; i< heights.Length; i++){
            for(int j = i + 1; j< heights.Length; j++){
                var max = heights[i];
                var bar = heights[j];
                int y;
                if(bar > max){
                    y = max * (j - i);
                }
                else{
                    y = bar * (j - i);
                }
                if(y > x) x = y;
            } 
        }
        return x;
    }
}
