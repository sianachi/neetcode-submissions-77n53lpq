
public class Solution
{
	public bool IsAnagram(string s, string t)
	{
		// s and t have the same characters but not necessarily in the same order

		Dictionary<char, int> charCountS = new Dictionary<char, int>();
		Dictionary<char, int> charCountT = new Dictionary<char, int>();

		if (s.Length != t.Length)
		{
			return false; // One is less or more than the other
		}

		for (int i = 0; i < s.Length; i++)
		{
			char currentS = s[i];
			char currentT = t[i];

			if (charCountS.ContainsKey(currentS))
			{
				charCountS[currentS]++;
			}
			else
			{
				charCountS.Add(currentS, 1);
			}

			
			if (charCountT.ContainsKey(currentT))
			{
				charCountT[currentT]++;
			}
			else
			{
				charCountT.Add(currentT, 1);
			}
		}

		foreach (var key in charCountS.Keys)
		{
            if(!charCountT.ContainsKey(key))
            {
                return false;
            }

			if (charCountS[key] != charCountT[key])
			{
				return false;
			}
		}

		return true;
	}
}
