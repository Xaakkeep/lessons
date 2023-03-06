/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

void task47()
{
    Console.WriteLine("Task 47");
    double[,] array = DoubleRandomArray(4, 3, -10, 10);
    Print2Array(array);

    double[,] DoubleRandomArray(int count = 2, int row = 2, int min = 1, int max = 10)
    {
        Random random = new Random();
        double[,] arr = new double[count, row];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = Math.Round(random.Next(min, max) + random.NextDouble(), 1);
            }
        }
        return arr;
    }

}

/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void task50()
{
    Console.WriteLine("Task 50");
    int[,] array = Random2Array(3, 4, 1, 10);
    int N = InputText("Введите искомое число: ");
    Print2Array(array);
    FindNNum(array, N);
    void FindNNum(Array arr, int num)
    {
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (Convert.ToInt32(arr.GetValue(i, j)) == num)
                {
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"{num} => такого числа в массиве нет");
        }
        else
        {
            Console.WriteLine($"Количество {num} в массиве => {count}");
        }

    }

}

/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

void task52()
{
    Console.WriteLine("Task 52");

    int[,] array = Random2Array(3, 4, 1, 10);

    Print2Array(array);

    SumRow(array);
    void SumRow(int[,] arr)
    {
        Console.Write($"Сумма каждого столбца: ");
        double count = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                count += arr[j, i];
            }
            count = Math.Round(count / arr.GetLength(1), 1);
            Console.Write($"[{count}] ");
            count = 0;
        }

    }

}


void task()
{
    Console.Write("Выбираите задачу\nЗадача 47\nЗадача 50\nЗадача 52\n");
    int i = InputText("");
    if (i == 47)
    {
        task47();
    }
    if (i == 50)
    {
        task50();
    }
    if (i == 52)
    {
        task52();
    }
}

task();

int InputText(String text = "Введите число N: ")
{
    int num;
    Console.Write(text);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}

int[,] Random2Array(int count = 3, int row = 3, int min = 1, int max = 10)
{
    int[,] arr = new int[count, row];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}


void Print2Array(Array arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr.GetValue(i, j)} ");
        }
        Console.WriteLine("]");
    }
}