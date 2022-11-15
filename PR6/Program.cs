/*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
cколько чисел больше 0 ввёл пользователь.
 0, 7, 8, -2, -2 -> 2
 1, -7, 567, 89, 223-> 3
 ----------------------------------------------------------
 Console.Write("Введите числа через пробел: ");
 int[] array = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

 void possitiveNumbers(int[] array)
 {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i] > 0)
         {
             count++;
         }
     }
     Console.WriteLine($"В массиве больше 0: {count} числа");
 }
 try
 {
     possitiveNumbers(array);
 }
 catch (FormatException)
 {
     Console.WriteLine("Неверный формат ввода!");
 }
 */
 //----------------------------------------------------------------------
 /* Напишите программу, которая найдёт точку пересечения двух прямых, 
  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
  значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//-----------------------------------------------------------------------

Console.Write("Введите k1: ");
 double k1 = double.Parse(Console.ReadLine());
 Console.Write("Введите k2: ");
 double k2 = double.Parse(Console.ReadLine());
 Console.Write("Введите b1: ");
 double b1 = double.Parse(Console.ReadLine());
 Console.Write("Введите b2: ");
 double b2 = double.Parse(Console.ReadLine());

 double x = (b1-b2)/(k2-k1);
 double y = (k2 * x + b2);

 Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");

*/