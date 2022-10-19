/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
 ------------------------------------------------------------------------
 
Console.Write("Ведите число: ");
 int number = Convert.ToInt32(Console.ReadLine());

 if ((number / 10 > 0) && (number / 100 == 0))
 {
     Console.WriteLine("Enter the  correct number!");
 }
 else 
 {
 number = number / 10;
 number = number % 10;
 Console.WriteLine(number);
 }
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
 ------------------------------------------------------------------------

Console.Write("Ведите Цифру: ");

 int number = Convert.ToInt32(Console.ReadLine());
 string numberText = Convert.ToString(number);
 if (numberText.Length > 2)
 {
   Console.WriteLine("Третья Цифра будет: " + numberText[2]);
 }
 else 
 {
   Console.WriteLine("Третьей Цифры НЕТ");
 }
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
 ------------------------------------------------------------------------

Console.Write("Ведите день недели от 1-7 дней: ");
 int number = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(

     number == 1 ? "Нет Понедельник" 
     :number == 2 ? "Нет Вторник"
     :number == 3 ? "Нет Среда"
     :number == 4 ? "Нет Четверг"
     :number == 5 ? "Нет Пятница"
     :number == 6 ? "Да Выходной Суббота!!! "
     :number == 7 ? "Да Выходной Воскресенье!!! "
 
     :"В неделе всего 7 дней!!! ");
*/
