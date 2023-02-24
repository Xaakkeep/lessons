# Домашняя работа

## Урок 5. Функции и одномерные массивы

### Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

### [345, 897, 568, 234] -> 2

```C#
Console.Write("Task 34\n");
int[] array = RandomArray(4, 100, 999);

PrintArray(array);
int EvenNum(Array array)
{
    int i = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            i++;
        }
    }
    return i;
}
Console.WriteLine($"Количество четных чисел в массиве - {EvenNum(array)}");
```

### Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

### [3, 7, 23, 12] -> 19

### [-4, -6, 89, 6] -> 0

```C#
Console.Write("Task 36\n");
int[] array = RandomArray(6, 1, 20);
PrintArray(array);

int SumNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}
Console.WriteLine($"Сумма четных элементов - {SumNum(array)}");
```

### Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

### [3 7 22 2 78] -> 76

```C#
Console.Write("Task 38\n");
int[] array = RandomArray(5, 1, 80);
PrintArray(array);

int diff;

int MaxArray(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max = arr[i];
        }
    }
    return max;
}
    int MinArray(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min = arr[i];
        }
    }
    return min;
}
Console.WriteLine($"Минимальное[{MinArray(array)}]");
Console.WriteLine($"Максимальное[{MaxArray(array)}]");
Console.WriteLine($"Разница между минимальным и максимальным [{diff = MaxArray(array) - MinArray(array)}]");
```
