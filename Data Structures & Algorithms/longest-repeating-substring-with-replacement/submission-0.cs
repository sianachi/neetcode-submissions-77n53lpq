public class Solution
{
	public int CharacterReplacement(string s, int k)
	{

		int left = 0;
		int right = 0;
		int maxLen = 0;
		int maxFreq = 0;
		
		Dictionary<char, int> charCount = new Dictionary<char, int>();

		
		while(right < s.Length)
		{
			char current = s[right];
			if (!charCount.ContainsKey(current))
			{
				charCount.Add(current, 1);
			}
			else
			{
				charCount[current]++;
			}
					
			maxFreq = Math.Max(maxFreq, charCount[current]);
			
			if ((right - left + 1) - maxFreq > k)
			{
				charCount[s[left]]--;
				left++;
			}
			
			maxLen = Math.Max(maxLen, right - left + 1);
			right++;
		}
		return maxLen;
	}
}
