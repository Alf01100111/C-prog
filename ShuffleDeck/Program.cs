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

//Создать колоду
void ArrayPrint(int[] ar)
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

int[] numbers = new int[13];`
int index = 0;
while (index < 13)
{
    numbers[index] = index;
    index++;
}

ArrayPrint(numbers);