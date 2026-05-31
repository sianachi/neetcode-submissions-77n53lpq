class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        # Use dfs to find '1's
        self.grid_height = len(grid)
        self.grid_width = len(grid[0])

        count = 0
        for row in range(self.grid_height):
            for col in range(self.grid_width):
                if grid[row][col] == "1":
                    count = count + 1
                    self.muteOtherCells(grid, row, col)
        
        return count


    def muteOtherCells(self, grid, row, col):
            if col < 0 or col >= self.grid_width or row < 0 or row >= self.grid_height:
                return # Search complete in a particular direction

            if grid[row][col] == "0":  # Already visited or water
                return
        
            grid[row][col] = "0"

            self.muteOtherCells(grid, row - 1, col)
            self.muteOtherCells(grid, row + 1, col)
            self.muteOtherCells(grid, row, col - 1)
            self.muteOtherCells(grid, row, col + 1)
            