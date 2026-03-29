public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int max = arr[arr.Length - 1];
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            int current = arr[i];
            
            if(i == arr.Length - 1)
            {
                arr[i] = -1;
            }
            else
            {
                arr[i] = max;
            }
            max = Math.Max(max, current);
        }   
        return arr;
    }
}