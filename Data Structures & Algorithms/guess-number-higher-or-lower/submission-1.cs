/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        
        int start = 1;
        int end = n;

        while(start <= end)
        {
            int pick = start + (end - start) / 2;
            int guessStatus = guess(pick);

            if(guessStatus == 0)
            {
                return pick;
            }
            else if(guessStatus == -1)
            {
                // Focus on the left after current
                end = pick - 1;
            }
            else
            {
                start = pick + 1;
            }
        }

        return -1;
    }
}