public class Solution
{
	public string MinWindow(string s, string t)
	{
		Dictionary<char, int> charCount = new Dictionary<char, int>();
		int left = 0;
		int right = 0;

		int currentSubScore = int.MaxValue;
		string currentSmallest = "";

		Dictionary<char, int> targetMap = new Dictionary<char, int>();
		foreach(char c in t) {
			if(!targetMap.ContainsKey(c)) targetMap[c] = 0;
			targetMap[c]++;
		}

		while (right < s.Length)
		{
			if (!charCount.ContainsKey(s[right]))
			{
				charCount.Add(s[right], 1);

			}
			else
			{
				charCount[s[right]]++;
			}

			while (left <= right)
			{
				bool validSequence = true;
				foreach (var pair in targetMap)
				{
					if(!charCount.ContainsKey(pair.Key) || charCount[pair.Key] < pair.Value)
					{
						validSequence = false;
						break;
					}
				}

				if (validSequence)
				{
					if (right - left + 1 < currentSubScore)
					{
						currentSubScore = right - left + 1;
						currentSmallest = s.Substring(left, currentSubScore);
					}

					charCount[s[left]]--;
					left++;
				}
				else
				{
					break;
				}
			}
			right++;
		}

		return currentSmallest;
	}
}