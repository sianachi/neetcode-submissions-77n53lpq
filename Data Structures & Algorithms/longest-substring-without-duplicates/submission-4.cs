
public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		if (string.IsNullOrEmpty(s)) return 0;
		int left = 0;
		int right = 0;
		
		List<char> buffer = new List<char>();
		int max = 1;
		
		//a, b, b, c, d
		while (right < s.Length)
		{
			if(!buffer.Contains(s[right]))
			{
				 buffer.Add(s[right]);
				 if(buffer.Count > max)
				 {
				 	max = buffer.Count;
				 }
				 right++;
			}
			else
			{
				// Pop the top
				buffer.RemoveAt(0);
				left++;
			}
		}
		return max;
	}
}
