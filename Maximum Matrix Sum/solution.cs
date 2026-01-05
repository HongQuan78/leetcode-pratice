public class Solution
{
    public long MaxMatrixSum(int[][] matrix)
    {
        long sum = 0;
        int counter = 0;
        int minAbs = int.MaxValue;

        int rows = matrix.Length;

        for (int rowIndex = 0; rowIndex < rows; rowIndex++)
        {
            int columns = matrix[rowIndex].Length;

            for (int columnIndex = 0; columnIndex < columns; columnIndex++)
            {
                int currentValue = matrix[rowIndex][columnIndex];

                if (currentValue < 0)
                {
                    counter++;
                }

                int absValue = Math.Abs(currentValue);
                sum += absValue;

                if (absValue < minAbs)
                {
                    minAbs = absValue;
                }
            }
        }

        if ((counter & 1) == 1)
        {
            sum -= 2L * minAbs;
        }

        return sum;
    }
}
