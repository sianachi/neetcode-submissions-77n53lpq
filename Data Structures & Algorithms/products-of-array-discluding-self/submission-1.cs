public class Solution
{
	public int[] ProductExceptSelf(int[] nums)
	{
		int[] output = new int[nums.Length];
		
		output[0] = 1;
		for(int i = 1; i < nums.Length; i++)
		{
			output[i] = output[i - 1] * nums[i - 1];
		}     
		
		// Now come from the right to the left
		int right = 1;
		for (int i = nums.Length - 1; i >= 0; i--)
		{
			output[i] *= right;
			right *= nums[i]; 
		}
		
		return output;
	}
}
