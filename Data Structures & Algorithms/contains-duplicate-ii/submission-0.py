class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        for i in range(len(nums)):
            # j is <= k away from i
            lim = min(i + k, len(nums) - 1) 
            j = i + 1

            while j <= lim:
                if nums[i] == nums[j]:
                    return True
                j = j + 1

        return False