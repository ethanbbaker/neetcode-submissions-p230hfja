public class Solution {
    public bool IsPalindrome(string s) {
        string ss = s.ToLower();
        string z = "";
        for(int i = 0; i<ss.Length; i++){
            if(char.IsLetterOrDigit(ss[i])){
                z += ss[i];
            }
        }
        for(int i = 0; i<z.Length/2; i++){
            if(z[i] == z[z.Length - i - 1]){
                continue;
            }
            else{
                return false;
            }
        }
        return true;
    }
}
