// Часы

int time = 0, hour = 0;

Console.Write("Введите часы: ");
int houruser = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минуты: ");
int min = Convert.ToInt32(Console.ReadLine());
hour = (houruser*5+min/12);

while (min-1 != hour)
{
    min ++;
    if (min % 12 == 0)
    {
        hour ++;
    }
    if (min == 60)
    {
        min = 0;
    }
    if (hour == 60)
    {
        hour = 0;
    }
time ++;
}

Console.Write("Стрелки пересеклись на :");
Console.Write(hour/5);
Console.WriteLine("часов");
Console.Write(min);
Console.WriteLine("минут");
Console.Write("Прошло времени :");
Console.Write(time);