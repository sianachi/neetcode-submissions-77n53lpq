class Solution:
    def search(self, nums: List[int], target: int) -> int:
        # Find the index of the smallest value by going right until the next value is larger than the current one.
      for i in range(len(nums) - 1, -1, -1):
        if nums[i - 1] > nums[i]:
          break
        
        # Perform a binary search on the left side first for target.
      left, right = 0, i - 1
      while left <= right:
        mid = left + (right - left) // 2
        if nums[mid] == target:
          return mid
        elif nums[mid] < target:
          left = mid + 1
        else:
          right = mid - 1
        
        # Perform a binary search on the right side for target.
      left, right = i, len(nums) - 1
      while left <= right:
        mid = left + (right - left) // 2
        if nums[mid] == target:
          return mid
        elif nums[mid] < target:
          left = mid + 1
        else:
          right = mid - 1

      return -1