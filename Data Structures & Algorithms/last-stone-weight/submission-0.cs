public class Solution
{
	public int LastStoneWeight(int[] stones)
	{
		PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
		
		foreach(var stone in stones)
		{
			pq.Enqueue(stone, -stone); // So it becomes a max heap
		}	
		
		while(pq.Count > 1)
		{
			var x = pq.Dequeue();
			var y = pq.Dequeue();
			
			if (x != y)
			{
				var diff = Math.Abs(x - y);
				pq.Enqueue(diff, -diff);
			}
		}
		
		
		if (pq.Count == 0)
			return 0;
		else 
			return pq.Peek();
			
	}
}