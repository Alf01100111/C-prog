//int numberA = new Random().Next(1,10); // 1 2 3 ... 9
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1,10); // 1 2 3 ... 9;
//Console.WriteLine(numberB);
//int result = numberA + numberB;
//Console.WriteLine(result);

int count = 0;
int distance = 10000;
int ffspeed = 1;
int sfspeed = 2;
int dogspeed = 5;
int friend = 2;

while (distance > 10)
{
  if(friend == 1)
  {
    int time = distance/(ffspeed + dogspeed);
    friend = 2;
  }
  if(friend == 2)
  {
    int time = distance/(sfspeed + dogspeed);
    friend = 1;    
  }
  distance = distance - (ffriend + sfriend) * time;
  count += 1;
}
Console.Write("Собака пробежит: ");
Console.WriteLine(count);
