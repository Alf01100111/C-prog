int row = Int32.Parse(Console.ReadLine());
int column = Int32.Parse(Console.ReadLine());

int [,] matrix = new int[row,column];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        System.Console.Write(matrix[i,j] + "\t"); // \t табуляция \n новая строка
    }
    System.Console.WriteLine();
}
