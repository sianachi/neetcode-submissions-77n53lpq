public class Solution
{
	public int ClimbStairs(int n)
	{
		// Base case - n == 1
		if (n <= 2)
			return n;
			
		return ClimbStairs(n - 1) + ClimbStairs(n - 2);
	}	
}
