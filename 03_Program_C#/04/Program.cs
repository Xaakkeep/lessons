int TakeConsoleInt(string str = "Введите число N: ")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

void task25()
{
    int A = TakeConsoleInt("Введите число А: ");
    int B = TakeConsoleInt("Введите число Б: ");
    // Console.Write("Введите число А: ");
    // int.TryParse(Console.ReadLine()!, out task25_A);
    // Console.Write("Введите число Б: ");
    // int.TryParse(Console.ReadLine()!, out task25_B);
    int stepB(int a, int b)
    {
        int power = 1;
        for (int i = 0; i < b; i++)
        {
            power *= a;

        }
        return power;
    }
    Console.WriteLine($"Число {A} в степени {B} = {stepB(A, B)}");
    Console.WriteLine($"Число {A} в степени {B} = {Math.Pow(A, B)}"); // Проще и лучше


}

/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

void task27()
{
    int N = TakeConsoleInt();

    int sum_N(int num)
    {
        int res = 0;
        while (num > 0)
        {
            res += num % 10;
            num = num / 10;

        }
        return res;
    }
    Console.WriteLine($"Сумма всех чисел в N[{N}] = {sum_N(N)}");


}

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

void task29()
{
    int length = TakeConsoleInt("Введите длину массива: ");
    int min = TakeConsoleInt("Начальный диапазон случайного числа: ");
    int max = TakeConsoleInt("Конечный диапазон случайного числа: ");

    int[] RandomArray(int Length, int minValue, int maxValue)
    {
        int[] array = new int[Length];
        Random random = new Random();
        for (int i = 0; i < Length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }
    void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length -1]}");
        Console.Write("]");
    }
    int[] array = RandomArray(length, min, max);
    PrintArray(array);   
}

void task()
{
    int i;
    Console.Write($"Выберите задание: \nЗадача 25\nЗадача 27\nЗадача 29\n");
    int.TryParse(Console.ReadLine()!, out i);
    if (i == 25)
    {
        task25();
    }
    if (i == 27)
    {
        task27();
    }
    if (i == 29)
    {
        task29();
    }

}
task();

