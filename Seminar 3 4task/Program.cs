void sqrtable(int n)
{
    int index = 1;
    while (index <= n)
    {
        int result = index*index;
        System.Console.Write($" {result},");
        index++;
    }
    System.Console.Write("\b \b");
}
sqrtable(16);