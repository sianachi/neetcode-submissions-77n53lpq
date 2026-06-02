class Solution:
    def rob(self, nums: List[int]) -> int:
        memo = {}
        def rob_house(index):
            if index >= len(nums):
                return 0
            if index in memo:
                return memo[index]
            
            # Option 1: Rob this house and skip the next one
            res = max(nums[index] + rob_house(index + 2), rob_house(index + 1))
            memo[index] = res
            return res

        return rob_house(0)