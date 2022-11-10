/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


 using System;
 using static System.Console;

 int A = AskNumber("A");
 int B = AskNumber("B");
 WriteLine($"{A},{B} => {Exponentiation(A,B)}");

 int AskNumber(string name) {
     Write($"Введите число {name}: ");
     return int.Parse(ReadLine());
 }

 int Exponentiation(int A, int B) {
     int result = 1;
     for(int i = 0; i < B; i++) {
         result = result*A;
     }
     return result;
 }
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


 string number = ReadLine("Введите число: ");
 Console.WriteLine(GetSum(number));

 string ReadLine(string message)
 {
     Console.Write(message);
     return Console.ReadLine()!;
 }

 int GetSum(string number)
 {
     int sum = 0;
     for (int i = 0; i < number.Length; i++)
     {
         sum += Convert.ToInt32(number[i]) - 48;

     }
     return sum ;
     }

     */

     /*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]


 Console.WriteLine("Введите массив из простых чисел :");
 string input = Console.ReadLine() ??"";
 string[] temp = input.Split(' ');

 int[] resultArray = new int[temp.Length];
 for (int i = 0; i < resultArray.Length; i++)
 {
     resultArray[i] = int.Parse(temp[i]);
 }
 for (int i = 0; i < resultArray.Length; i++)
 {
     Console.Write($"{resultArray[i]}, "); 
 }
*/