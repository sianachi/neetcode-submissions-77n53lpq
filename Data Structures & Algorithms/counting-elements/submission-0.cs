public class Solution {
    public int CountElements(int[] arr) {
        int output = 0;

        foreach(int val in arr)
        {
            if (arr.Contains(val + 1))
                output++;
        }
        return output;
    }
}
