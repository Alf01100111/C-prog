
void Method1()
{
    System.Console.WriteLine("Alf");
}

Method1();

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "метод 21", count: 4);

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(5, "asdf");
System.Console.WriteLine(res);