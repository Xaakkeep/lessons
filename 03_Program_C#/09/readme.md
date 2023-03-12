# Домашняя работа

## Урок 9. Рекурсия

### Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

+ N = 5 -> "5, 4, 3, 2, 1"
+ N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

```C#
void task64()
{
    Console.WriteLine("Task 64");
    Console.Write("Натуральные число от N до 1\n");
    int N = InputText();

    int NumbPlusOne(int num)
    {
        if (num == 1) return 1;
        Console.Write($"{num} ");
        return 1 * NumbPlusOne(num - 1);
    }
    Console.Write($"N = {N} -> ");
    Console.Write($"{NumbPlusOne(N)} ");
}
```

### Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

+ M = 1; N = 15 -> 120
+ M = 4; N = 8. -> 30

```C#
void task66()
{
    Console.WriteLine("Task 66");
    Console.Write("Сумма натуральных элементов в промежутке от M до N\n");
    int M = InputText("Введите число M: ");
    int N = InputText();

    int SumNM(int m, int n)
    {
        if (m == n) return m;
        return m + SumNM(m + 1, n);
    }
    Console.Write($"M = {M}; N = {N} -> {SumNM(M, N)} ");
}
```

### Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

+ m = 2, n = 3 -> A(m,n) = 9
+ m = 3, n = 2 -> A(m,n) = 29

```C#
void task68()
{
    Console.WriteLine("Task 66");
    Console.Write("Вычисления функции Аккермана\n");
    int M = InputText("Введите число M: ");
    int N = InputText();

    int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else
            if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
            else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    Console.WriteLine(Akkerman(M,N));
}
```

#### Выбор задачи и остальные функции

```C#
void task()
{
    Console.Write("Выбираите задачу\nЗадача 64\nЗадача 66\nЗадача 68\n");
    int i = InputText("Ввод: ");
    if (i == 64)
    {
        task64();
    }
    if (i == 66)
    {
        task66();
    }
    if (i == 68)
    {
        task68();
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
```
