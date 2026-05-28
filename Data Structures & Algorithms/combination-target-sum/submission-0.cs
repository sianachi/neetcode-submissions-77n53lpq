public class Solution
{
	public List<List<int>> CombinationSum(int[] nums, int target)
	{
		// Get unique numbers that sum up to target
		
		// First sort array 
		Array.Sort(nums);
		
		List<List<int>> output = new List<List<int>>();
		CombinationSum(nums, target, 0, new List<int>(), output);
		
		return output;
	}

	public void CombinationSum(int[] nums, int target, int index, List<int> current, List<List<int>> output)
	{
		int sum = current.Sum();
					
		if (index >= nums.Length ||  sum > target)
		{
			return;
		}
		
		if(current.Sum() == target)
		{
			output.Add(new List<int>(current));
		}
		else
		{
			current.Add(nums[index]);
			CombinationSum(nums, target, index, current, output);
			
			// Backtrack - Try without the current Index
			current.Remove(nums[index]);
			CombinationSum(nums, target, index + 1, current, output);
		}
	}
}
