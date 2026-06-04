
public class Solution
{
	public int[] CountBits(int n)
	{
		int[] output = new int[n + 1];
		
		for (int i = 0; i <= n; i++)
		{
			output[i] = HammingWeight(i);
		}
		
		return output;
	}

	private int HammingWeight(int n)
	{
		int output = 0;
		for (int i = 0; i < 32; i++)
		{
			if ((1 << i & n) != 0)
			{
				output++;
			}
		}

		return output;
	}
}
