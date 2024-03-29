﻿/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

void task2()
{
    int task2_A, task2_B;
    Console.Write($"Задача 2\n");
    Console.Write($"Enter A: ");
    int.TryParse(Console.ReadLine()!, out task2_A);
    Console.Write($"Enter B: ");
    int.TryParse(Console.ReadLine()!, out task2_B);

    if (task2_A > task2_B)
    {
    Console.Write($"max A = {task2_A} min B = {task2_B}\n");
    }
    else
    {
    Console.Write($"max B = {task2_B} min A = {task2_A}\n");
    }
}

// task2();

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

void task4()
{
    int task4_A, task4_B, task4_C;
    Console.Write($"Задача 4\n");
    Console.Write($"Enter A: ");
    int.TryParse(Console.ReadLine()!, out task4_A);
    Console.Write($"Enter B: ");
    int.TryParse(Console.ReadLine()!, out task4_B);
    Console.Write($"Enter C: ");
    int.TryParse(Console.ReadLine()!, out task4_C);

    if (task4_A > task4_B & task4_A > task4_C)
    {
        Console.Write($"A = {task4_A}\n");
    }
    else if (task4_B > task4_C)
    {
        Console.Write($"B = {task4_B}\n");    
    }
    else
    {
        Console.Write($"C = {task4_C}\n");
    }
}

// task4();

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

void task6()
{
    int task6_N;
    Console.Write($"Задача 6\n");
    Console.Write($"Enter N: ");
    int.TryParse(Console.ReadLine()!, out task6_N);

    if (task6_N % 2 == 0)
    {
        Console.Write($"N = {task6_N} - Четное\n");
    }
    else
    {
        Console.Write($"N = {task6_N} - Нечетное\n");
    }
}

// task6();

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 
*/

void task8()
{
    int task8_N, task8_res;
    Console.Write($"Задача 8\n");
    Console.Write($"Enter N: ");
    int.TryParse(Console.ReadLine()!, out task8_N);
    task8_res = 1;
    while (task8_res < task8_N)
    {
        Console.Write($"{task8_res + 1} ");
        task8_res += 2;
    }
}

void task()
{
    int i;
    Console.Write($"Выберите задание: \nЗадача 2\nЗадача 4\nЗадача 6\nЗадача 8\n");
    int.TryParse(Console.ReadLine()!, out i);
    if (i == 2)
    {
        task2();
    }
    if (i == 4)
    {
        task4();
    }
    if (i == 6)
    {
        task6();
    }
    if (i == 8)
    {
        task8();
    }


}
task();