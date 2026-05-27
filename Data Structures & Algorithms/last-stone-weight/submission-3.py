import heapq

class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        # Heapify the stones array as a max heap
        stones_max_heap = []
        heapq.heapify(stones_max_heap)

        for stone in stones:
            heapq.heappush(stones_max_heap, -stone)
        
        while len(stones_max_heap) > 1:
            x = heapq.heappop(stones_max_heap)
            y = heapq.heappop(stones_max_heap)
            if x != y:
                heapq.heappush(stones_max_heap, x - y)

        return abs(stones_max_heap[0]) if stones_max_heap else 0