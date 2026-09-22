class Solution:
    def maxTurbulenceSize(self, arr: List[int]) -> int:
       if len(arr) < 2:
           return len(arr)

       max_turbulance = 1
       current = 1
       i = 0

       # Check till the second to the last because of checks
       while i < len(arr) - 1:
            if self.currentIsTurbulent(i, arr):
                current = current + 1

                if current > max_turbulance:
                    max_turbulance = current
            else:
                current = 2 if arr[i] != arr[i + 1] else 1
                if current > max_turbulance:
                    max_turbulance = current
            i = i + 1 
       return max_turbulance
    
    def currentIsTurbulent(self, k : int, arr: List[int]) -> bool:
        if k == 0 or k >= len(arr) - 1:
            return False
        return (arr[k - 1] > arr[k] < arr[k + 1]) or (arr[k - 1] < arr[k] > arr[k + 1])