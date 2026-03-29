public class Solution
{
	public int[] ProductExceptSelf(int[] nums)
	{
		int[] output = new int[nums.Length]; 
		int currentIndex = 0;
		
		for(; currentIndex < nums.Length; currentIndex++)
		{
			int left = 0;
			
			int sum = 1;
			while (left < currentIndex)
			{
				sum *= nums[left];
				left++;
			}
			
			int right = currentIndex + 1;
			
			while (right < nums.Length)
			{
				sum *= nums[right];
				right++;
			}
			
			output[currentIndex] = sum;
		}
		return output;
	}
}