
void writediap(int plane)
{
    if (plane == 1)
    {
        System.Console.WriteLine("x>0 y>0");
    }
    else if (plane == 2)
    {
        System.Console.WriteLine("x<0 y>0");
    }
    else if (plane == 3)
    {
        System.Console.WriteLine("x<0 y<0");
    }
    else if (plane == 4)
    {
        System.Console.WriteLine("x>0 y<0");
    }
    else System.Console.WriteLine("неверныый ввод");
}

writediap(2);