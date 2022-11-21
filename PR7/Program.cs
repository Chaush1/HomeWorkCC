/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
----------------------------------------------------

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] intArray = new double[m, n];
void FillArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(-100,100) / 10.0;
        }
    }
}
void printArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(intArray[i, j]  );
        }
        Console.WriteLine();
    }
}
FillArray();
printArray();
*/

/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
2и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
-------------------------------------------------------------

Console.Write("Введите номер строки: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int M = int.Parse(Console.ReadLine());

int[,] NewArray = GetRandomArray(4, 4, 1, 10);
PrintArray(NewArray);
SearchElement(NewArray, N, M);


int[,] GetRandomArray(int rows, int columns, int minVolue, int maxVolue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minVolue, maxVolue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SearchElement(int[,] array, int n, int m)
{
    if (n >= array.GetLength(0) || m >= array.GetLength(1))
    {
        Console.WriteLine($"{n}{m} Tакого элемента в массиве нет.");
    }
    else Console.WriteLine($"{array[n, m]}");
}
*/

/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
-----------------------------------------------------------------

int[,] NewArray = GetRandomArray(4, 4, 1, 10);
PrintArray(NewArray);
Console.WriteLine("Среднее арифметическое каждого столбца:");
AverageColumns(NewArray);

int[,] GetRandomArray(int rows, int columns, int minVolue, int maxVolue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minVolue, maxVolue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double AverageColumns(int[,] array)
{
    double average = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        //average=Convert.ToDouble(sum/array.GetLength(0));
        average=array.GetLength(0) !=0 ? (double)sum/array.GetLength(0) : 0;
        Console.Write("{0,4:F1};", average);
    }
    return average;
}
*/