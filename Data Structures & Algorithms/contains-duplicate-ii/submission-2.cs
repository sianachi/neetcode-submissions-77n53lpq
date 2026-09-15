public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        List<int> set = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int cur = nums[i];

            if (set.Contains(cur)) 
            {
                return true;
            }

            set.Add(cur);

            if (set.Count > k)
            {
                set.RemoveAt(0);
            }

        }

        return false;
    }
}