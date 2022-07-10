
int[] RandomArray8()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

int[] GetArrayRandom(int size)
{
    int[] rar = new int[size];
    for (int i = 0; i < rar.Length; i++)
    {
        rar[i] = new Random().Next(0, 2);
    }
    return rar;
}

void PrintArray(int[] arr)
{
    foreach (var items in arr)
    {
        System.Console.Write(items + " ");
    }
}

System.Console.WriteLine("введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Massiv = GetArrayRandom(size);
PrintArray(Massiv);
