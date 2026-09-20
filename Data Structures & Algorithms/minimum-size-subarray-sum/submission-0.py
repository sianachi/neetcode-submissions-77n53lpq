class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        min_length = len(nums) + 1

        buffer = []

        for i in nums:
            # Grow the buffer till sum >= target and then shrink from left till no longer >= target
            buffer.append(i)

            buffer_size = sum(buffer) 
            while (buffer_size >= target and len(buffer) > 0):
                min_length = min(len(buffer), min_length)

                # Remove from the top
                buffer.pop(0) 

                buffer_size = sum(buffer)

        if min_length == len(nums) + 1:
            return 0
            
        return min_length

        