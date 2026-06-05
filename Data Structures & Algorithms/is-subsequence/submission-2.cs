public class Solution
{
	public bool IsSubsequence(string s, string t, int i = 0, int j = 0)
	{
        if (s.Length == 0)
            return true;
            
		if (i >= s.Length || j >= t.Length)
		{
			return false;
		}
		
		if (s[i] == t[j])
		{
            if(i == s.Length - 1)
				return true;
			return IsSubsequence(s, t, i + 1, j + 1);
		}
		else
		{
			return IsSubsequence(s, t, i, j + 1);
		}
		
	}
}