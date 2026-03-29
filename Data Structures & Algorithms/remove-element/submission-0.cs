public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int non_val_index = 0;
        int i = 0;

        while(non_val_index < nums.Length && i < nums.Length)
        {
            int current_non_val = nums[non_val_index];

            if (current_non_val == val)
            {
                non_val_index++;
                continue;
            }
            else
            {
                nums[i] = current_non_val;
                i++;
                non_val_index++;
            }
        }
        return i;

    }
}