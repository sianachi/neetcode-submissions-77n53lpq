public class Solution
{
	public int LongestCommonSubsequence(string text1, string text2)
	{
		int?[,] memo = new int?[text1.Length, text2.Length];
		return LCS(text1, text2, 0, 0, memo);
	}
	
	public int LCS(string text1, string text2, int text1Index, int text2Index, int?[,] memo)
	{
		if (text1Index >= text1.Length || text2Index >= text2.Length)
			return 0;
		
		if (memo[text1Index, text2Index].HasValue)
			return memo[text1Index, text2Index].Value;
			
		if (text1[text1Index] == text2[text2Index])
		{
			memo[text1Index, text2Index] = 1 + LCS(text1, text2, text1Index + 1, text2Index + 1, memo);
			return memo[text1Index, text2Index].Value;
		}
		
		var decisionA = LCS(text1, text2, text1Index + 1, text2Index, memo);
		var decisionB = LCS(text1, text2, text1Index, text2Index + 1, memo);
		
		memo[text1Index, text2Index] = Math.Max(decisionA, decisionB);
		return memo[text1Index, text2Index].Value;
	}
}
