int getPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    else if (x < 0 && y > 0)
    {
        return 2;
    }
    else if (x < 0 && y < 0)
    {
        return 3;
    }
    else if (x > 0 && y < 0)
    {
        return 4;
    }
    return -1;
}


void printPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("плоскость 1");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("плоскость 2");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("плоскость 3");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine("плоскость 4");
    }
    else System.Console.WriteLine("неверные данные");
}

int planesNumber = getPlanesNumber(-1, -2);
System.Console.WriteLine(planesNumber);

printPlanesNumber(-1, -2);