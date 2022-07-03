
System.Console.WriteLine("ВВедите число");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (; num != 0; num/=10)
{
    count++;
}

System.Console.WriteLine(count);