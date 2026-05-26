import heapq

class KthLargest:

    def __init__(self, k: int, nums: List[int]):
        self.k = k
        self.nums = nums
        heapq.heapify(self.nums) # Heapify the nums list in place
        while len(self.nums) > self.k:
            heapq.heappop(self.nums)

    def add(self, val: int) -> int:

        heapq.heappush(self.nums, val) # Push the new value onto the heap

        if len(self.nums) > self.k:
            heapq.heappop(self.nums) # Pop the smallest element from the heap

        return self.nums[0] # Return the kth largest element