// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// bool isParsed = int.TryParse(Console.ReadLine(), out int a);

// if (!isParsed)
// {
//     Console.WriteLine("Ошибка! Не правильно введены данные");
//     return;
// }

// if (a < 1)
// {
//     Console.WriteLine("0");
//     return;
// }

// int sum = GetSumNumbers(a);

// Console.WriteLine(sum);

// int GetSumNumbers(int number)
// {
//     int sum = 0;

//     for (int i = 1; i <= number; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }







// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// bool isParsed = int.TryParse(Console.ReadLine(), out int a);

// if (!isParsed)
// {
//     Console.WriteLine("Ошибка! Не правильно введены данные");
//     return;
// }

// int count = CountDigit(a);
// Console.WriteLine(count);


// int CountDigit(int number)
// {
//     int count;

//     for (count = 0; number != 0; count++)
//     {
//         number /= 10;
//     }

//     return count;
// }










// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

// bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

// if (!isParsedN)
// {
//     Console.WriteLine("Ошибка! Не правильно введены данные");
//     return;
// }

// if (n < 1)
// {
//     Console.WriteLine("0");
//     return;
// }

// int comp = GetCompositionNumbers(n);

// Console.WriteLine(comp);

// int GetCompositionNumbers(int number)
// {
//     int composition = 1;

//     for (int i = 1; i <= number; i++)
//     {
//         composition *= i;
//     }
//     return composition;
// }





// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите размер массива");
bool isParsedS = int.TryParse(Console.ReadLine(), out int s);

Console.WriteLine("Введите левую границу чисел");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите правую границу чисел");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if (!isParsedS || !isParsedA || !isParsedB)
{
    Console.WriteLine("Ошибка! Не правильно введены данные");
    return;
}

int[] array = GetRandomArray(s, a, b);
PrintArray(array);

int[] GetRandomArray(int size, int borderL, int borderR)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(borderL, borderR + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}