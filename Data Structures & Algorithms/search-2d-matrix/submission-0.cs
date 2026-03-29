public class Solution
{
	public bool SearchMatrix(int[][] matrix, int target)
	{
		for(int i = 0; i < matrix.Length; i++)
		{
			if(matrix[i].Contains(target))
			{
				return true;
			}
		}
		return false;
	}
}
