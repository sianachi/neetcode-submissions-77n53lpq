class Solution:
    def floodFill(self, image: List[List[int]], sr: int, sc: int, color: int) -> List[List[int]]:
        startingColour = image[sr][sc]

        if startingColour == color:
            return image;  # Soloution is correct already
        
        self.matrix_height = len(image)
        self.matrix_width = len(image[0])

        self.floodFillRecursively(image, sc, sr, color, startingColour)

        return image

    def floodFillRecursively(self, image, x, y, colour, startingColour):
        if x < 0 or x >= self.matrix_width or y < 0 or y >= self.matrix_height:
            return
        
        currentCell = image[y][x]
        if currentCell != startingColour:
            return
        
        image[y][x] = colour
        
        self.floodFillRecursively(image, x, y + 1, colour, startingColour)
        self.floodFillRecursively(image, x, y - 1, colour, startingColour)
        self.floodFillRecursively(image, x + 1, y, colour, startingColour)
        self.floodFillRecursively(image, x - 1, y, colour, startingColour)
