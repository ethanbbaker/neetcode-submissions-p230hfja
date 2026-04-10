public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        for(int i = 0; i < s.Length; i++){
            for(int j = 0; j < t.Length; j++){
                if(s[i] == t[j]){
                    t = t.Remove(j, 1);
                    break;
                }
            }
        }
        return t.Length == 0;
    }
}
