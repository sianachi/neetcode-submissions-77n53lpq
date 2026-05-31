class Solution:
    def maxAreaOfIsland(self, grid: List[List[int]]) -> int:
        # Use dfs to find '1's
        self.grid_height = len(grid)
        self.grid_width = len(grid[0])

        max_count = 0
        for row in range(self.grid_height):
            for col in range(self.grid_width):
                if grid[row][col] == 1:
                    count = self.muteOtherCells(grid, row, col)
                    max_count = max(count, max_count)
        
        return max_count


    def muteOtherCells(self, grid, row, col):
            if col < 0 or col >= self.grid_width or row < 0 or row >= self.grid_height:
                return 0 # Search complete in a particular direction

            if grid[row][col] == 0:  # Already visited or water
                return 0
        
            grid[row][col] = 0

            count = 1

            count += self.muteOtherCells(grid, row - 1, col)
            count += self.muteOtherCells(grid, row + 1, col)
            count += self.muteOtherCells(grid, row, col - 1)
            count += self.muteOtherCells(grid, row, col + 1)
            
            return count