class Solution:
    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        count = 0
        curr_sum = 0
        target = k * threshold

        for i in range(len(arr)):
            curr_sum += arr[i]

            if i >= k:
                curr_sum -= arr[i - k]

            if i >= k - 1 and curr_sum >= target:
                count += 1

        return count