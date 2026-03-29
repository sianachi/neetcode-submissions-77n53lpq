public class Solution
{
	public int Search(int[] nums, int target)
	{
		
		int start = 0;
		int end = nums.Length - 1;
		
		while(start <= end)
		{
			int searchIndex = (start + end) / 2;
			int cur = nums[searchIndex];
			
			if(target == cur)
			{
				return searchIndex;
			}
			else if (target > cur)
			{
				// Focus on the right side of the array
				start = searchIndex + 1;
			}
			else
			{
				// Focus on the left side of the array
				end = searchIndex - 1;
			}
		}
		return -1;
    }
}
