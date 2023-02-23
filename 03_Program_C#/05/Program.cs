int TakeConsoleInt(string str = "Введите число N: ")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

/* 

*/

void task30()
{

}

/* 

*/

void task31()
{

}

void task()
{
    int i;
    Console.Write($"Выберите задание: \nЗадача 25\nЗадача 27\nЗадача 29\n");
    int.TryParse(Console.ReadLine()!, out i);
    if (i == 25)
    {
        task25();
    }
    if (i == 27)
    {
        task27();
    }
    if (i == 29)
    {
        task29();
    }

}
task();