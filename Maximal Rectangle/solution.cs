public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix.Length == 0) 
        {
            return 0;
        }

        int[] heights = new int[matrix[0].Length];
        int bestArea = 0;

        for (int i = 0; i < matrix.Length; i++)  
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {   
                if(matrix[i][j] == '1')
                {
                    heights[j]++;
                }
                else
                {
                    heights[j] = 0;
                }
            }
            
            bestArea = Math.Max(bestArea, FindBestArea(heights));
        }

        return bestArea;

    }

    private int FindBestArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int bestArea = 0;
        for (int i = 0; i <= heights.Length; i++)
        {
            int currentHeight = (i == heights.Length) ? 0 : heights[i];

            while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
            {
                int h = heights[stack.Pop()];
                int w = stack.Count == 0 ? i : i - stack.Peek() - 1;
                bestArea = Math.Max(bestArea, h * w);
            }

            stack.Push(i);
        }

        return bestArea;
    }
}