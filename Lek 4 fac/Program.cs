﻿
// double Factorial(double n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// System.Console.WriteLine(Factorial(5));

// for (double i = 1; i < 40; i++)
// {
//     System.Console.WriteLine($"{i}! = {Factorial(i)}");    
// }


double Fibonacci(int n)
{
    if(n==1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}