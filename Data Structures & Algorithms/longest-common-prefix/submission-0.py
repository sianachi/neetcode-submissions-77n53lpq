class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if len(strs) == 0:
            return "" 

        current_prefix = ""

        index = 0

        while True:
            if index >= len(strs[0]):
                break
            else:
                cur = current_prefix + strs[0][index]

                valid = True
                for str in strs:
                    if not str.startswith(cur):
                        valid = False
                
                if valid and len(cur) > len(current_prefix):
                    current_prefix = cur
                
                index += 1
        
        return current_prefix
