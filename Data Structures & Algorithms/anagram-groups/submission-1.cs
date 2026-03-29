public class Solution
{	
    public List<List<string>> GroupAnagrams(string[] strs)
	{
		// Anagrams should be added to the same lists
		
		// Starting with a bruteforce solution
		Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
		
		for(int i = 0; i < strs.Length; i++)
		{
			string rearrangedString = RearrangeString(strs[i]);
			
			if(anagrams.ContainsKey(rearrangedString))
			{
				anagrams[rearrangedString].Add(strs[i]);
			}
			else
			{
				anagrams.Add(rearrangedString, new List<string>(){strs[i]});
			}
		}
		
		return anagrams.Values.ToList();
	}
	
	public string RearrangeString(string str)
	{
		char[] strChar = str.ToCharArray();
		Array.Sort(strChar);
		
		return new string(strChar);		
	}
	
}
