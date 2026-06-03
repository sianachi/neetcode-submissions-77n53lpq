public class Solution
{
	public int UniquePaths(int m, int n)
	{
		// Can only go down or right
		// m = rows
		// n = cols

		// 0 0 0 0
		// 0 0 0 0
		// 0 0 0 0
		// 0 0 0 0


		// 1 1 1 1
		// 1 2 3 4
		// 1 3 6 10
		// 1 4 10 20
		
		List<List<int>> memo = new List<List<int>>();
		
		for (int i = 0; i < m; i++)
		{
			memo.Add(new List<int>());
			
			for (int j = 0; j < n; j++)
			{
				if (i == 0 || j == 0)
					memo[i].Add(1);
				else
					memo[i].Add(memo[i][j - 1] + memo[i - 1][j]);
			}
		}
		
		return memo[m-1][n-1];
	}

	
}
