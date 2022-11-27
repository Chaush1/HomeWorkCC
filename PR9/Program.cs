/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
-----------------------------------------------------------------

Console.Write("Введите число больше 1:");
            int number = int.Parse(Console.ReadLine());
            
            void NumberCounter(int number)
            {
                if (number < 0) Console.Write($"{number} не целое число");
                if (number == 0) return;
                Console.Write("{0,4}", number);
                NumberCounter(number - 1);
            }
            
            NumberCounter(number);   
*/

/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
---------------------------------------------------------------------

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;
            
    if (m > n)
    {
      m = n;
      n = temp;
    }
            
PrintSumm(m, n, temp=0);
            
    void PrintSumm(int m, int n, int summ)
    {
       summ = summ + n;
            if (n <= m)
    {
    Console.Write($"Сумма элементов -> {summ} ");
    return;
    }
PrintSumm(m, n - 1, summ);
    }
            
    int InputNumbers(string input)
{
Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
*/     
    
/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
-------------------------------------------------------------------------

Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
            
Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
            
AkkermanFunction(m,n);
    void AkkermanFunction(int m, int n)
{
Console.Write(Akkerman(m, n));
}
    int Akkerman(int m, int n)
{
    if (m == 0)
{
return n + 1;
}
    else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
    else
{
return (Akkerman(m - 1, Akkerman(m, n - 1)));
}
}
*/
