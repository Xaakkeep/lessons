# Домашняя работа 
## Урок 2. Базовые алгоритмы

```c#
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void task10()
{
    int task10_N;
    Console.WriteLine($"Задача 10");
    Console.Write($"Введите 3х значное число: ");
    int.TryParse(Console.ReadLine()!, out task10_N);

    if (task10_N < 100 || task10_N > 999)
    {
        Console.WriteLine($"Неверный ввод");
    }
    else
    {
        string task10_N_text = Convert.ToString(task10_N);
        int i = 1;
        int[] array = new int[task10_N_text.Length];
        array[i] = (int)char.GetNumericValue(task10_N_text[i]);
        Console.WriteLine(array[i]);
    }

    // if (task10_N < 100 || task10_N > 999)
    // {
    //     Console.WriteLine($"Число меньше 100 или больше 1000");
    // }
    // else
    // {
    //     Console.WriteLine($"Втора цифра числа N - {task10_N = task10_N / 10 % 10}");

    // }
}

// task10();

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void task13()
{
    int task13_N;
    Console.WriteLine($"Задача 13");
    Console.Write($"Введите число N: ");
    int.TryParse(Console.ReadLine()!, out task13_N);

    if (task13_N < 100)
    {
        Console.WriteLine($"Третьей цифры нет");
    }
    else
    {
        string task13_N_text = Convert.ToString(task13_N);
        int i = 2;
        int[] array = new int[task13_N_text.Length];
        array[i] = (int)char.GetNumericValue(task13_N_text[i]);
        Console.WriteLine($"Третье цифра числа N - {array[i]}");
    }

    // if (task13_N < 100)
    // {
    //     Console.WriteLine($"Третьей цифры нет");
    // }
    // else if (task13_N > 100 && task13_N < 999)
    // {
    //     Console.WriteLine($"Третье цифра числа N - {task13_N = task13_N % 10}");
    // }
    // else if (task13_N > 999 && task13_N < 9999)
    // {
    //     Console.WriteLine($"Третье цифра числа N - {task13_N = task13_N / 10 % 10}");
    // }
    // else if (task13_N > 9999 && task13_N < 99999)
    // {
    //     Console.WriteLine($"Третье цифра числа N - {task13_N = task13_N / 100 % 10}");
    // }

}

// task13();

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void task15()
{
    int task15_N;
    Console.WriteLine($"Задача 15");
    Console.Write($"Введите день недели от 1 до 7: ");
    int.TryParse(Console.ReadLine()!, out task15_N);

    if (task15_N == 6 || task15_N == 7)
    {
        Console.WriteLine($"Да - Выходной");
    }
    else if (task15_N > 7)
    {
        Console.WriteLine($"Неверный ввод");
    }
    else
    {
        Console.WriteLine($"Нет - Будний");
    }
}

// task15();
```