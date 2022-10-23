Console.Clear();
Console.WriteLine("Введите номер задачи: 24, 26, 28 или 30");
int z = Convert.ToInt32(Console.ReadLine());

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

if (z == 24)
{
    Console.WriteLine("Введите число");
    bool isParsedA = int.TryParse(Console.ReadLine(), out int a);

    if (!isParsedA)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    if (a < 1)
    {
        Console.WriteLine("0");
        return;
    }

    int sum = GetSumNumbers(a);
    Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}

// метод для задачи 28 - находит сумму чисел от 1 до заданного

int GetSumNumbers(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}




// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

if (z == 26)
{
    Console.WriteLine("Введите число");
    bool isParsedNum = int.TryParse(Console.ReadLine(), out int num);

    if (!isParsedNum)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    int count = CountDigit(num);
    Console.WriteLine($"Количество цифр в числе - {count}");
}

// метод для задачи 26 - находит количество цифр в числе

int CountDigit(int number)
{
    int count;

    for (count = 0; number != 0; count++)
    {
        number /= 10;
    }

    return count;
}










// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

if (z == 28)
{
    Console.WriteLine("Введите число");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

    if (!isParsedN)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    if (n < 1)
    {
        Console.WriteLine("0");
        return;
    }

    int comp = GetCompositionNumbers(n);

    Console.WriteLine($"Произведение чисел от 1 до {n} = {comp}");
}

// метод для задачи 28 - находит произведение чисел от 1 до заданного

int GetCompositionNumbers(int number)
{
    int composition = 1;

    for (int i = 1; i <= number; i++)
    {
        composition *= i;
    }
    return composition;
}





// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

if (z == 30)
{
    Console.WriteLine("Введите размер массива");
    bool isParsedS = int.TryParse(Console.ReadLine(), out int s);

    Console.WriteLine("Введите левую границу чисел");
    bool isParsedL = int.TryParse(Console.ReadLine(), out int l);

    Console.WriteLine("Введите правую границу чисел");
    bool isParsedR = int.TryParse(Console.ReadLine(), out int r);

    if (!isParsedS || !isParsedL || !isParsedR)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    int[] array = GetRandomArray(s, l, r);
    Console.WriteLine("Массив случайных чисел:");
    PrintArray(array);
}

// метод для задачи 30 - получение массива заданного размера из случайных чисел в заданном интервале

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

// метод для задачи 30 - выводит (распечатывает) массив в консоль

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}