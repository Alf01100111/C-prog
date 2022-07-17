int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");       
        }
        Console.WriteLine();
    }
}



int[,] SwapMatrix(int[,] matrix)
{
    int[,] resultmatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < resultmatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            resultmatrix[i,j] = matrix[j,i];
        }
        
    }
    return resultmatrix;
}

int[,] firstmatrix = GetMatrix(3,6,0,10);
PrintMatrix(firstmatrix);

System.Console.WriteLine();

int[,] resultmatrix = SwapMatrix(firstmatrix);
PrintMatrix(resultmatrix);
