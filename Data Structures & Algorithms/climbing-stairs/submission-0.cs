public class Solution
{
	public int ClimbStairs(int n)
	{
		List<int> steps = new List<int>()
		{
			1, 2
		};
		
		if(n < 3)
			return steps[n - 1];
		
		for (int i = 2; i < n; i++)
		{
			steps.Add(steps[i - 1] + steps[i - 2]);
		}
		
		return steps[n - 1];
	}	
}
