
void Expon(int A, int B, int count = 0, int result = 1)
{
    if (count == B)
    {
        System.Console.Write(result);
        return;
    }
    result *= A;
    count++;
    Expon(A, B, count, result);
}

Expon(5, 5);