string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string text2 = Method4(5, ";lkj");
System.Console.WriteLine(text2);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} X {j} = {i * j}");
    }
    System.Console.WriteLine();
}