int PointsCheck(string card)
{
    int point = 0;
    switch (card[0])
    {
        case '2':
            point = 2;
            break;
        case '3':
            point = 3;
            break;
        case '4':
            point = 4;
            break;
        case '5':
            point = 5;
            break;
        case '6':
            point = 6;
            break;
        case '7':
            point = 7;
            break;
        case '8':
            point = 8;
            break;
        case '9':
            point = 9;
            break;
        case 'T':
            point = 10;
            break;
        case 'J':
            point = 10;
            break;
        case 'Q':
            point = 10;
            break;
        case 'K':
            point = 10;
            break;
        case 'A':
            point = 11;
            break;
    }
    return point;
}

int result = PointsCheck("Jc");
System.Console.WriteLine(result);
