public class Solution
{
	int matrix_height;
	int matrix_width;

	public int[][] FloodFill(int[][] image, int sr, int sc, int color)
	{
		int startingPixelColour = image[sr][sc];
		if (startingPixelColour == color) return image;

		matrix_height = image.Length;
		matrix_width = image[0].Length;

		Queue<(int x, int y)> processingQueue = new Queue<(int x, int y)>();
		processingQueue.Enqueue((sc, sr));

		while (processingQueue.Count() > 0)
		{
			var current_cell = processingQueue.Dequeue();

			if (current_cell.y < 0 || current_cell.y >= matrix_height
			|| current_cell.x < 0 || current_cell.x >= matrix_width)
			{
				continue;		
			}
			
			var current_value = image[current_cell.y][current_cell.x];
			
			if (current_value == startingPixelColour)
			{
				image[current_cell.y][current_cell.x] = color;
				// Enqueue things around
				processingQueue.Enqueue((current_cell.x - 1, current_cell.y));
				processingQueue.Enqueue((current_cell.x + 1, current_cell.y));
				processingQueue.Enqueue((current_cell.x, current_cell.y + 1));
				processingQueue.Enqueue((current_cell.x, current_cell.y - 1));
			}
		}
			
		
		return image;
	}
}