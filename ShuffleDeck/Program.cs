// void Shuffle(int[] arr)
// {
//     // создаем экземпляр класса Random для генерирования случайных чисел
//     Random rand = new Random();

//     for (int i = arr.Length - 1; i >= 1; i--)
//     {
//         int j = rand.Next(i + 1);

//         int tmp = arr[j];
//         arr[j] = arr[i];
//         arr[i] = tmp;
//     }
// }

// int[] numbers = new int[13];
// int index = 0;
// while (index < 13)
// {
//     numbers[index] = index;
//     index++;
// }


//Создать колоду
void ArrayPrint(string[] ar)
{
    int count = ar.Length;
    int position = 0;    
    while (position < count)
    {
        System.Console.Write(" ");
        System.Console.Write(ar[position]);
        position++;
    }
}


string[] deck = {"Ad", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd",
                 "Ac", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc",
                 "Ah", "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh",
                 "As", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks"};

void Shuffle(string[] arr)
{
    
    int i = arr.Length -1;
    Random rand = new Random();

while (i >= 1)
{
    int j = rand.Next(i + 1);
    string tmp = arr[j];
    arr[j] = arr[i];
    arr[i] = tmp;     
    
    i--;
}
}

Shuffle(deck);
ArrayPrint(deck);