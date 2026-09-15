class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {boolean}
     */
    containsNearbyDuplicate(nums: number[], k: number): boolean {
        const set = new Set<number>();

        for (let i = 0; i < nums.length; i++)
        {
            let cur = nums[i];

            if (set.has(cur)) 
            {
                return true;
            }

            set.add(cur);

            if (set.size > k)
            {
                set.delete(nums[i - k]);
            }

        }

        return false;
    }
}
