/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 
*/

void task54()
{
    Console.WriteLine("Task 54");

    int[,] array = Random2Array(4, 4, 1, 10);
    Print2Array(array);
    largeToSmall(array);
    Console.WriteLine("Отсортированный массив:");
    Print2Array(array);

    void largeToSmall(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(1) - 1; k++)
                {
                    if (arr[i, k] < arr[i, k + 1])
                    {
                        int temp = arr[i, k + 1];
                        arr[i, k + 1] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }
    }
}

/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void task56()
{
    Console.WriteLine("Task 56");

    int[,] array = Random2Array(4, 4, 1, 10);
    Print2Array(array);

    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i, j];
        }
        return sumLine;
    }


}

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void task58()
{
    Console.WriteLine("Task 58");
    Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
    int m = InputText("Введите число строк 1-й матрицы: ");
    int n = InputText("Введите число столбцов 1-й матрицы (и строк 2-й): ");
    int p = InputText("Введите число столбцов 2-й матрицы: ");
    int range = InputText("Введите диапазон случайных чисел: от 1 до ");

    int[,] firstMartrix = new int[m, n];
    CreateArray(firstMartrix);
    Console.WriteLine($"\nПервая матрица:");
    WriteArray(firstMartrix);

    int[,] secomdMartrix = new int[n, p];
    CreateArray(secomdMartrix);
    Console.WriteLine($"\nВторая матрица:");
    WriteArray(secomdMartrix);

    int[,] resultMatrix = new int[m, p];

    MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
    Console.WriteLine($"\nПроизведение первой и второй матриц:");
    WriteArray(resultMatrix);

    void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i, k] * secomdMartrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }

    void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] / 10 <= 0)
                    Console.Write($" {array[i, j]} ");

                else Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void CreateArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(range);
            }
        }
    }
}

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void task60()
{
    Console.WriteLine("Task 60");
    Console.WriteLine($"\nВведите размер массива X x Y x Z:");
    int x = InputText("Введите X: ");
    int y = InputText("Введите Y: ");
    int z = InputText("Введите Z: ");
    Console.WriteLine($"");

    int[,,] array3D = new int[x, y, z];

    Random3DAray(array3D);
    Print3DArray(array3D);

}

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void task62()
{
    Console.WriteLine("Task 62");
    Console.WriteLine("Спиральный массив N на N");
    int n = InputText("Введите N");
    int[,] sqareMatrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    WriteArray(sqareMatrix);

    void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] / 10 <= 0)
                    Console.Write($" {array[i, j]} ");

                else Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }


}

void task()
{
    Console.Write("Выбираите задачу\nЗадача 54\nЗадача 56\nЗадача 58\nЗадача 60\nЗадача 62\nВвод: ");
    int i = InputText("");
    if (i == 54)
    {
        task54();
    }
    if (i == 56)
    {
        task56();
    }
    if (i == 58)
    {
        task58();
    }
    if (i == 60)
    {
        task60();
    }
    if (i == 62)
    {
        task62();
    }
}

task();

//Ввод текста
int InputText(String text = "Введите число N: ")
{
    int num;
    Console.Write(text);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}

//Вывод двухмерного массива
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

//Рандомный двухмерный массив
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

void Random3DAray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

