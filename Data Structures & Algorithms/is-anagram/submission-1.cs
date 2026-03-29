
public class Solution
{
	public bool IsAnagram(string s, string t)
	{
		// s and t have the same characters but not necessarily in the same order

		Dictionary<char, int> charCount = new Dictionary<char, int>();
		

		if (s.Length != t.Length)
		{
			return false; // One is less or more than the other
		}

		for (int i = 0; i < s.Length; i++)
		{
			char currentS = s[i];
			charCount[currentS] = charCount.GetValueOrDefault(currentS, 0) + 1;	
		}
				
		for (int i = 0; i < t.Length; i++)
		{
			char currentT = t[i];
			charCount[currentT] = charCount.GetValueOrDefault(currentT, 0) - 1;	
		}

		return charCount.Values.All(x => x == 0);
	}
}