/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void task41()
{
    Console.WriteLine("Task 41");
    int[] array = RandomArray();
    PrintArray(array);
    array = Console.ReadLine()!.Split(' ', ',').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    PrintArray(array);
    Console.WriteLine($"Количество чисел больше 0 - {count}");
         
    
}

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void task43()
{
    Console.WriteLine("Task 43");
    
}

void task()
{
    Console.Write("Выбираите задачу\nЗадача 41\nЗадача 43\n");
    int i = InputText("");
    if (i == 41)
    {
        task41();
    }
    if (i == 43)
    {
        task43();
    }
}

int[] RandomArray(int size = 3, int min = 1, int max = 10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("{");
    Console.Write(String.Join(", ", arr));
    Console.WriteLine("}");
}

int InputText(String text = "Введите число N: ")
{
    int num;
    Console.Write(text);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}

task();