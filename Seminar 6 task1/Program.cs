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

void ReversArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i -1];
        array[size - i - 1] = temp;
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(", ", array));
}

// int[] ar = CreateRandArr(5);
// PrintArray(ar);

// ReversArray(ar);
// PrintArray(ar);

int a = 2;
void Fool(int number)
{
    number = 1000;
}

Fool(a);
System.Console.WriteLine(a);