public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
       int nonDuplicateIndex = 0;
       int lastNonDuplicate = nums[0];
       int i = 1;

       while (i < nums.Length && nonDuplicateIndex < nums.Length)
       {
            while(nonDuplicateIndex < nums.Length && nums[nonDuplicateIndex] == lastNonDuplicate)
                nonDuplicateIndex++;
            
            if(nonDuplicateIndex < nums.Length)
            {
                nums[i] = nums[nonDuplicateIndex];
                lastNonDuplicate = nums[i];
                i++;
            }
            
       }
        return i;
    }
}