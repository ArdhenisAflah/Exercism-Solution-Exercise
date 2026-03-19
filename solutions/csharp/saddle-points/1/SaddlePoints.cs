public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0); // baris (y)
        int cols = matrix.GetLength(1); // kolom (x)
        int colIndex = -1;
        int rowIndex = -1;
        Console.WriteLine("Searching for Saddle Points (Max in Row, Min in Col)...");

        for (int i = 0; i < rows; i++)
        {
            // gonna FInd the maximum element in the current row
            int rowMax = -1;
            colIndex = -1;

            for (int w = 0; w < cols; w++)
            {
                if (matrix[i, w] > rowMax)
                {
                    rowMax = matrix[i, w];
                    Console.WriteLine($"rowMax coord: {i},{w}");
                }
            }

            for (int m = 0; m < cols; m++)
            {
                if (matrix[i, m] == rowMax)
                {
                    colIndex = m;
                    rowIndex = i;
                    bool isGoodTree = true;

                    for (int k = 0; k < rows; k++)
                    {
                        if (matrix[k, colIndex] < rowMax)
                        {
                            isGoodTree = false;
                        }


                    }
                    if (isGoodTree)
                    {
                        // Console.WriteLine($"coord good tree x:{colIndex}y:{rowIndex}, value:{grid[rowIndex, colIndex]}");
                        yield return (rowIndex+1, colIndex+1);
                    }
                }



            }


        }
    }
}
    
