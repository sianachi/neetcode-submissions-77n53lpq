
public class Solution
{
	public bool IsValid(string s)
	{
	   var pairs = new Dictionary<char, char>()
	   {
		 {')', '('},
		 {']', '['},
		 {'}', '{'}
	   };

		Stack<char> stack = new Stack<char>();

		for (int i = 0; i < s.Length; i++)
		{
			char cur = s[i];

			if (pairs.ContainsValue(cur))
			{
				stack.Push(cur);
			}
			else if (pairs.ContainsKey(cur))
			{
				if (stack.Count == 0 || pairs[cur] != stack.Pop())
				{
					return false;
				}
			}
		}

		return stack.Count == 0;
	}
}