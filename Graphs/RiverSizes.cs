using System;
using System.Collections.Generic;

class Program
{
    public static List<int> RiverSizes(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        bool[,] visited = new bool[rows, cols];

        List<int> riverSizes = new List<int>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int size = TraverseRiver(matrix, visited, i, j);
                if (size > 0)
                {
                    riverSizes.Add(size);
                }
            }
        }

        return riverSizes;
    }

    static int TraverseRiver(int[,] matrix, bool[,] visited, int row, int col)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (row < 0 || row >= rows || col < 0 || col >= cols || visited[row, col] || matrix[row, col] == 0)
        {
            return 0;
        }

        visited[row, col] = true;
        int size = 1;

        size += TraverseRiver(matrix, visited, row - 1, col);
        size += TraverseRiver(matrix, visited, row + 1, col);
        size += TraverseRiver(matrix, visited, row, col - 1);
        size += TraverseRiver(matrix, visited, row, col + 1);

        return size;
    }
}
