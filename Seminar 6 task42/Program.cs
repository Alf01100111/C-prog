

string doubletransf(int num)
{
    int remains = 2;
    string result = string.Empty;
    while (num > 0)
    {
        remains = num % 2;
        num /= 2;
        result += Convert.ToString(remains);
    }
    return result;
}

System.Console.WriteLine(doubletransf(50)); //развернуть строку.


