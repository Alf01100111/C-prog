
int GetSum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.WriteLine("ВВедите число");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(GetSum(num));

// Сумма чисел от 1 до а

