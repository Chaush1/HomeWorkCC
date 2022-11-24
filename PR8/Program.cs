/*Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
-----------------------------------------------------------

int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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
*/

/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
-----------------------------------------------------------------
Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

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
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
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

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/

/* Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

//-------------------------------------------------------------
void Filltable(int [,] table)
{
    Random random = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
    for (int j = 0; j < table.GetLength(1); j++)
        {
        table[i,j] = new Random().Next (1,10);
        }
    }
}
void Printtable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
    for (int j = 0; j < table.GetLength(1); j++)
        {
        Console.Write(table[i,j] + "\t" );
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите размер квадратного массива ");
int sizeTable = Convert.ToInt32(Console.ReadLine());


int [,] tableA = new int [sizeTable,sizeTable];
Filltable(tableA);
Console.WriteLine("Матрица - А");
Printtable(tableA);
Console.WriteLine();
int [,] tableB = new int [sizeTable,sizeTable];
Filltable(tableB);
Console.WriteLine("Матрица - B");
Printtable(tableB);
Console.WriteLine();
int[,] tableC = new int[sizeTable, sizeTable];
int[,] MultiMatrix(int[,] tableA, int[,] tableB)
{
    
    for (int i = 0; i < tableA.GetLength(0); i++)
    {
        for (int j = 0; j < tableA.GetLength(0); j++)
        {
            for (int k = 0; k < tableA.GetLength(0); k++)
            {
                tableC[i, j] = tableC[i, j] + (tableA[i, k] * tableB[k, j]);
            }
        }
        
    }
    return tableC;
}

Console.WriteLine("Произведение матриц А*В");
MultiMatrix(tableA,tableB);
Printtable(tableC);
*/

/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
-------------------------------------------------------------------
bool CheckForUniqueness(int[,,] arr, int searchNumber)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                if (arr[x, y, x] == searchNumber)
                {
                    return false;
                }
            }
        }
    }
    return true;
}
void FillArray(int[,,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                while (true)
                {
                    int number = new Random().Next(10, 100);
                    if (CheckForUniqueness(arr, number))
                    {
                        arr[y, z, x] = number;
                        break;
                    }
                }
            }
        }
    }
}
void PrintArray(int[,,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write($"{arr[y, z, x]} (у:{y}, z:{z}, x:{x}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] numbers = new int[2, 2, 2];
FillArray(numbers);
PrintArray(numbers);
*/

/* Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
--------------------------------------------------
int[,] array = new int[4, 4];

int n = 1;
int i = 0;
int j = 0;

while (n <= 4 * 4)
{
    array[i, j] = n;
    if (i <= j + 1 && i + j < 4 - 1)
        ++j;
    else if (i < j && i + j >= 4 - 1)
        ++i;
    else if (i >= j && i + j > 4 - 1)
        --j;
    else
        --i;
    ++n;
}

PrintArray(array);

void PrintArray(int[,] sparray)
{
    for (int i = 0; i < sparray.GetLength(0); i++)
    {
        for (int j = 0; j < sparray.GetLength(1); j++)
        {
            Console.Write(sparray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
*/