
bool FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }    
    return false;
}

int[] arr = {6,7,19,345,3};
System.Console.WriteLine(FindNum(arr,4));
