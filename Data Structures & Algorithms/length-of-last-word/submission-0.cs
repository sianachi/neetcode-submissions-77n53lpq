public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words[words.Length - 1].Length;
    }
}