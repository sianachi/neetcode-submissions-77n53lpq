
public class Solution
{
	public int LongestConsecutive(int[] nums)
	{
		HashSet<int> set = new HashSet<int>(nums);
		
		int maxCount = 0;
		
		foreach (var element in nums)
		{
            if(set.Contains(element - 1))
                continue;
			
            int len = 1;

            while (set.Contains(element + len))
            {
                len++;
            }
            maxCount = Math.Max(len,maxCount);
		}		
		
		return maxCount;
	}
}
