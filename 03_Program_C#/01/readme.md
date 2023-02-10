# Домашняя работа 
## Урок 1. Знакомство с языком программирования С#
```C#
/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int task2_A, task2_B;
Console.Write($"Задача 2\n");
Console.Write($"Enter A: ");
int.TryParse(Console.ReadLine()!, out task2_A);
Console.Write($"Enter B: ");
int.TryParse(Console.ReadLine()!, out task2_B);

if (task2_A > task2_B)
{
    Console.Write($"A = {task2_A}\n");
}
else
{
    Console.Write($"B = {task2_B}\n");
}


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

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

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

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


/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 
*/

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
```