/*

*/

void task40()
{
    Console.WriteLine("Task 40");
    int[] array = RandomArray(InputText("Size: "), InputText("Min: "), InputText("Max: "));
    PrintArray(array);
}

/*

*/

void task41()
{
    Console.WriteLine("Task 41");
}

/*

*/

void task42()
{
    Console.WriteLine("Task 42");
}

void task()
{
    Console.Write("Выбираите задачу\nЗадача 40\nЗадача 41\nЗадача 42\n");
    int i = InputText("");
    if (i == 40)
    {
        task40();
    }
    if (i == 41)
    {
        task41();
    }
    if (i == 42)
    {
        task42();
    }
}

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(Array arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr.GetValue(i)}] ");
    }
    Console.WriteLine();
}

int InputText(String text = "Введите число N: ")
{
    int num;
    Console.Write(text);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}

task();