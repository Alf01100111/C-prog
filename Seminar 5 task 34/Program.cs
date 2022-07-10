
int[] CreateRandArr(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,200);
    }
    return array;
}

int FindQuanTwodig(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += (array[i]<99 && array[i]>9) ? 1 : 0;
    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(", ", array));
}

int[] arres = CreateRandArr(10);
PrintArray(arres);
System.Console.WriteLine(FindQuanTwodig(arres));