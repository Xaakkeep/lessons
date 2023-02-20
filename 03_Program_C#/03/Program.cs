/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void task19()
{
    int task19_N, task19_N1, task19_N2, digit;
    Console.WriteLine($"Задача 19");
    Console.Write($"Введите число N: ");
    int.TryParse(Console.ReadLine()!, out task19_N);
    task19_N2 = 0;
    task19_N1 = task19_N;

    while (task19_N1 > 0)
    {
        digit = task19_N1 % 10;
        task19_N1 = task19_N1 / 10;
        task19_N2 = task19_N2 * 10;
        task19_N2 = task19_N2 + digit;
    }
    if (task19_N == task19_N2)
    {
        Console.WriteLine($"Число N[{task19_N}] - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число N[{task19_N}] - не является палиндромом");
    }

}

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void task21()
{
    double[] task21_A = new double[3];
    double[] task21_B = new double[3];
    Console.Write($"Введите координату X1: ");
    double.TryParse(Console.ReadLine()!, out task21_A[0]);
    Console.Write($"Введите координату Y1: ");
    double.TryParse(Console.ReadLine()!, out task21_A[1]);
    Console.Write($"Введите координату Z1: ");
    double.TryParse(Console.ReadLine()!, out task21_A[2]);
    Console.Write($"Введите координату X2: ");
    double.TryParse(Console.ReadLine()!, out task21_B[0]);
    Console.Write($"Введите координату Y2: ");
    double.TryParse(Console.ReadLine()!, out task21_B[1]);
    Console.Write($"Введите координату Z2: ");
    double.TryParse(Console.ReadLine()!, out task21_B[2]);

    double task21_D = Math.Round(Math.Sqrt(Math.Pow(task21_B[0] - task21_A[0], 2) + Math.Pow(task21_B[1] - task21_A[1], 2) + Math.Pow(task21_B[2] - task21_A[2], 2)), 2); //расчет расстояния между точками А и В в 3D пространстве
    Console.WriteLine($"Расстояние между точками А и В в 3D пространстве - {task21_D}");
}

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void task23()
{
    int task23_N, task23_res;
    Console.Write($"Задача 23\n");
    Console.Write($"Введите число N: ");
    int.TryParse(Console.ReadLine()!, out task23_N);
    task23_res = 1;
    Console.WriteLine($"Таблица кубов от 1 до {task23_N}");
    while (task23_res <= task23_N)
    {
        Console.Write($"[{Math.Pow(task23_res, 3)}] ");
        task23_res += 1;
    }
}

void task()
{
    int i;
    Console.Write($"Выберите задание: \nЗадача 19\nЗадача 21\nЗадача 23\n");
    int.TryParse(Console.ReadLine()!, out i);
    if (i == 19)
    {
        task19();
    }
    if (i == 21)
    {
        task21();
    }
    if (i == 23)
    {
        task23();
    }

}
task();