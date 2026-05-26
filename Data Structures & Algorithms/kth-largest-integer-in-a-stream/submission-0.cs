
public class KthLargest
{
	PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
	int _k;
	
	public KthLargest(int k, int[] nums)
	{
		_k = k;
		
		// Initalize stuff
		foreach(var num in nums)
		{
			Add(num);
		}
	}

	public int Add(int val)
	{
		// Add val and return kth value
		priorityQueue.Enqueue(val,val);
		
		if (priorityQueue.Count > _k)
		{
			priorityQueue.Dequeue();
		}
		
		return priorityQueue.Peek();
	}
}
