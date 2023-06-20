

public class ZeroMatrix
{
    public static void Zero(int[][] matrix)
    {
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> columns = new HashSet<int>();

        for(int row = 0; row < matrix.Length; row++)
        {
            for (int column = 0; column < matrix[0].Length; column++)
            {
                if (matrix[row][column] == 0)
                {
                    if (!rows.Contains(row))
                    {
                        rows.Add(row);
                    }
                    if (!columns.Contains(column))
                    {
                        columns.Add(column);
                    }
                }
            }
        }
        addZeroes(rows, columns, matrix);

    }


    private static void addZeroes(HashSet<int> rows,HashSet<int> columns, int[][] matrix)
    {
        //rows
        foreach (int element in rows)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[element][i] = 0;
            }
            
        }
        //columns
        foreach (int element in columns)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[i][element] = 0;
            }
        }
    }

}