void task10()
{
    int i;
    Console.Write("Введите число N: ");
    string task10_N = Console.ReadLine()!;
    Console.Write("Введите номер числа который вы хотите узнать: ");
    int.TryParse(Console.ReadLine()!, out i);
    i -= 1;
    int[] array = new int[task10_N.Length];
    
    array[i] = (int)char.GetNumericValue(task10_N[i]);
    Console.WriteLine(array[i]);


}
task10();