
public class MyStack
{
	Queue<int> pq = new Queue<int>();
	
	public MyStack()
	{

	}

	public void Push(int x)
	{
		pq.Enqueue(x);
		
		// Queue - FIFO
		// Stack - LIFO
		// Things go to the back in queues
		// Move ever other thing to the end of the queue
		
		for (int i = 0; i < pq.Count - 1; i++)
		{
			pq.Enqueue(pq.Dequeue());
		}
	}

	public int Pop()
	{
		return pq.Dequeue();
	}

	public int Top()
	{
		return pq.Peek();
	}

	public bool Empty()
	{
		return !pq.Any();
	}
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */