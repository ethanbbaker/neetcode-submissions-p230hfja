public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++){
            char[] c = strs[i].ToArray();
            Array.Sort(c);
            string key = new string(c);
            if(!dic.TryGetValue(key, out var list)){
                list = new List<string>();
                dic.Add(key, list);
            }
            list.Add(strs[i]);
        }
        return dic.Values.ToList();
    }
}
