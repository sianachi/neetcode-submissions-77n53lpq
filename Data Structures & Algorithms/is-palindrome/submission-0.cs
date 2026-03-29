
public class Solution
{
	public bool IsPalindrome(string s)
	{
		//First clean string
		char[] cleaned = s.Where(c => char.IsLetterOrDigit(c)).ToArray();
		
		// Compare second half to the first half
		for (int i = cleaned.Length - 1, j = 0; i >= 0; i--, j++)
		{
			if(char.ToLower(cleaned[i]) != char.ToLower(cleaned[j]))
				return false;
		}
		return true;
	}
}
