# Домашняя работа

## Урок 4. Функции

```C#
int TakeConsoleInt(string str = "Введите число N: ")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}
```

### Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

### 3, 5 -> 243 (3⁵)

### 2, 4 -> 16

```C#
int A = TakeConsoleInt("Введите число А: ");
int B = TakeConsoleInt("Введите число Б: ");

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
```

### Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

### 452 -> 11

### 82 -> 10

### 9012 -> 12

```C#
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
```

### Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

### 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

### 6, 1, 33 -> [6, 1, 33]

```C#
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
```
