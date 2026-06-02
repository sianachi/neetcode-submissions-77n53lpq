public class Solution
{
	Dictionary<int, List<int>> preqDict = new Dictionary<int, List<int>>();
	HashSet<int> visited = new HashSet<int>();
	HashSet<int> completed = new HashSet<int>();

	public bool CanFinish(int numCourses, int[][] prerequisites)
	{
		for (int i = 0; i < numCourses; i++) preqDict[i] = new List<int>();
		foreach (var pair in prerequisites)
		{
			preqDict[pair[0]].Add(pair[1]);
		}

		for (int i = 0; i < numCourses; i++)
		{
			if (!CheckIfCanFinish(i)) return false;
		}
		return true;
	}

	private bool CheckIfCanFinish(int course)
	{
		if (visited.Contains(course))
		{
			return false;
		}
		if (completed.Contains(course))
		{
			return true;
		}

		visited.Add(course);

		foreach (var preq in preqDict[course])
		{
			if (CheckIfCanFinish(preq) == false)
			{
				return false;
			}
		}

		visited.Remove(course);
		completed.Add(course);
		return true;
	}
}