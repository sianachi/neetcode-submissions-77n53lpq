class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        carry_over = 1
        for i in range(len(digits) - 1, -1, -1):
            digits[i] = digits[i] + carry_over
            carry_over = 0

            if digits[i] >= 10:
                digits[i] -= 10
                carry_over += 1
        
        if carry_over >= 1:
            digits.insert(0, carry_over)

        return digits
            
            

        