
void ChangePosNeg(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;      
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ,", array));
}

int[] Arr = {-4, -8, 8, 2};
ChangePosNeg(Arr);
PrintArray(Arr);