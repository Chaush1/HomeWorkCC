/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
-----------------------------------------------------------------------
Console.WriteLine("Длина массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
//-----------------------------------------------------------------------------
/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
-----------------------------------------------------------------------------
void arrayRandom(int[] array)
 {   
     Console.WriteLine($"Массив заполненный случайными числами: ");
     for (int i = 0; i < array.Length; i++)
     {
         array[i] = new Random().Next(-99, 100);
         Console.Write($"{array[i]} ");
     }
         Console.WriteLine();
 }
 void arraySumNotEven(int[] array)
 {   
     Console.WriteLine($"Нужные нам элементы: ");
     int sum = 0;
     for (int i = 1; i < array.Length; i+=2)
     {
         sum = sum + array[i];
         Console.Write($"{array[i]} ");
     }    
         Console.WriteLine();
         Console.WriteLine($"Cумма элементов нечётных позициях: {sum} ");
 }
 Console.WriteLine("Введите количество элементов массива: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[n];
 arrayRandom(array);
 arraySumNotEven(array);
*/

//--------------------------------------------------------------------------
/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

//---------------------------------------------------------------------------
Console.WriteLine("Введите Mассив:");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FillArrayRandomNumbers(number);
Console.WriteLine("Массив:");

PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}
Console.WriteLine($"Всего в Mассиве чисел: {number.Length}"); 
Console.WriteLine($"Максимальное: {max}");
Console.WriteLine($"Минимальное: {min}");
Console.WriteLine($"Разница между Max и Min элементов массива: {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/