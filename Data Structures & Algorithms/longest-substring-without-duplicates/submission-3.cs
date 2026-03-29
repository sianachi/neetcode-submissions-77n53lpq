
public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		if (s.Length <= 1)
			return s.Length;

		int max_length = 1;
		for (int i = 0; i < s.Length - 1; i++)
		{
			List<char> inner_list = new List<char>();
			inner_list.Add(s[i]);

			for (int j = i + 1; j < s.Length; j++)
			{
				if (inner_list.Contains(s[j]))
				{
					// Duplicate found - restart search from next index
					break;
				}
				else
				{
					inner_list.Add(s[j]);
					if (inner_list.Count > max_length)
					{
						max_length = inner_list.Count;
					}
				}
				
				
			}
		}
		return max_length;
	}
}
