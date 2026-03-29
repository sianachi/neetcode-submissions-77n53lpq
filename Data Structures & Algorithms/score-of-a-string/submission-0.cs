public class Solution {
    public int ScoreOfString(string s) 
    {
        int output = 0;
        for (int i = 1; i < s.Length; i++)
        {
            output += Math.Abs(s[i]-s[i-1]);
        }    
        return output;
    }
}