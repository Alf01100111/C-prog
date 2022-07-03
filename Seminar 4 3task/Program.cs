
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int FindFactorial(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

System.Console.WriteLine(FindFactorial(num));