
public class Solution
{
	public int ClimbStairs(int n)
	{
		// Base case - n == 1
		int[] dp = new int[] {0, 1, 1};

		for (int i = 0; i < n; i++)
		{
			dp[2] = dp[0] + dp[1];
			dp[0] = dp[1];
			dp[1] = dp[2];
		}	
		
		return dp[2];
	}
}
