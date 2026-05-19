public class Solution
{
	public List<List<int>> LevelOrder(TreeNode root)
	{
		List<List<int>> output = new List<List<int>>();
		
		if(root == null)
			return output;
		
		Queue<TreeNode> queue = new Queue<TreeNode>();
		queue.Enqueue(root);
			
		while(queue.Count > 0)
		{
			int level = queue.Count();
			List<int> levelList = new List<int>();
			
			for (int i = 0; i < level; i++)
			{
				var current = queue.Dequeue();
				levelList.Add(current.val);

				// First queue the left
				if (current.left != null)
					queue.Enqueue(current.left);

				// Then queue the right - so the stuff at the left comes before the stuff at the right
				if(current.right != null)
					queue.Enqueue(current.right);
			}
			output.Add(levelList);
		}	
		
		return output;
	}
}
