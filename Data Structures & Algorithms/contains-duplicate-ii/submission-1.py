class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:

        buffer = set() # Idea is to keep this array size : k

        for i in range(len(nums)):
            if nums[i] in buffer:
                return True
            
            buffer.add(nums[i])

            # If len (nums) > k - move sliding window right
            if len(buffer) > k:
                buffer.remove(nums[i - k])

        return False
