public class Solution
{
	public List<List<int>> ThreeSum(int[] nums)
	{
		List<List<int>> output = new List<List<int>>();
		
		Array.Sort(nums);
		
		for (int i = 0; i < nums.Length - 2; i++)
		{
			if (i > 0 && nums[i] == nums[i - 1]) continue;
			for (int j = i + 1; j < nums.Length - 1; j++)
			{
				if (j > i + 1 && nums[j] == nums[j - 1]) continue;
				// Binary search k - the third number
				int start = j + 1;
				int end = nums.Length - 1;
				
				int ijSum = nums[i] + nums[j];
				int search = 0 - ijSum;
				
				while(start <= end)
				{
					int current = start + (end - start) / 2;
					if (nums[current] == search)
					{
						output.Add(new List<int>(){nums[i], nums[j], nums[current]});
						break;
					}
					if (nums[current] > search)
					{
						end = current - 1;
					} 
					else
					{
						start = current + 1;
					}
				}
			}
		}
		
		return output;
	}
}