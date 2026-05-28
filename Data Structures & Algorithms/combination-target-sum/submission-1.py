class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        nums.sort()
        output = []
        self.backtrack(nums, target, 0, [], output)
        return output

    def backtrack(self, nums: List[int], target: int,
     index: int, current: List[int], output: List[List[int]]):
        
        cur_list_sum = sum(current)

        if cur_list_sum == target:
            output.append(list(current))
            return
        
        if index >= len(nums) or cur_list_sum > target:
            return
        else:
            current.append(nums[index])
            self.backtrack(nums, target, index, current, output)

            # Backtrack
            current.pop()
            self.backtrack(nums, target, index + 1, current, output)