class Solution:
    def replaceElements(self, arr: List[int]) -> List[int]:
        max_value = -1
        for i in range(len(arr) - 1, -1, -1):
            current_val = arr[i]
            if i == len(arr) - 1:
                arr[i] = -1
            else:
                arr[i] = max_value
            max_value = max(current_val, max_value)
        return arr