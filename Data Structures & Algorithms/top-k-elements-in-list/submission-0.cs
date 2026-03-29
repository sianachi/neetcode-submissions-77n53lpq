
public class Solution
{
	public int[] TopKFrequent(int[] nums, int k)
	{
		Dictionary<int, int> num_count = new Dictionary<int, int>();
		
		for(int i = 0; i < nums.Length; i++)
		{
            if(!num_count.ContainsKey(nums[i]))
                num_count.Add(nums[i],0);
                
			num_count[nums[i]]++;
		}	
		
		// k - number of top coutns to return
		
		int[] output = new int[k];
		
		int j = 0;
		foreach (var num in num_count.OrderByDescending(x => x.Value))
		{
			if (j == output.Length)
				break;
			
			output[j] = num.Key;
			j++;
		}
		
		return output;
	}
}
