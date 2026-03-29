
public class Solution
{
	public int LongestConsecutive(int[] nums)
	{
		HashSet<int> set = new HashSet<int>(nums);
		
		int maxCount = 0;
		
		foreach (var element in nums)
		{
				
			int count = 1;
			int elementCopy = element;
			while (set.Contains(elementCopy + 1))
			{
				count++;
				elementCopy++;
			}
			
			if(maxCount < count)
				maxCount = count;
		}		
		
		return maxCount;
	}
}
